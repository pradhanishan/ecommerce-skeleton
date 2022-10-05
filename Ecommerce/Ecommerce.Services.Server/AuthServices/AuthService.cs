using AutoMapper;
using Ecommerce.Constants;
using Ecommerce.DataAccess.Repositories.UnitsOfWork;
using Ecommerce.Models.DTOS.User;
using Ecommerce.Models.Entities;
using Microsoft.AspNetCore.Http;
using Microsoft.Extensions.Configuration;
using Microsoft.IdentityModel.Tokens;
using System;
using System.Collections.Generic;
using System.IdentityModel.Tokens.Jwt;
using System.Linq;
using System.Security.Claims;
using System.Security.Cryptography;
using System.Text;
using System.Threading.Tasks;

namespace Ecommerce.Services.Server.AuthServices
{
    public sealed class AuthService : IAuthService
    {
        private readonly IUnitOfWork _unitOfWork;
        private readonly IMapper _mapper;
        private readonly IConfiguration _configuration;

        public AuthService(IUnitOfWork unitOfWork, IMapper mapper, IConfiguration configuration)
        {
            _unitOfWork = unitOfWork;
            _mapper = mapper;
            _configuration = configuration;
        }

        public async Task<ServiceResponse<GetRegisterUserDTO>> RegisterUser(PostRegisterUserDTO registerUser)
        {
            ServiceResponse<GetRegisterUserDTO> response = new();

            try
            {
                // Return bad response if the username trying to be registered exists
                if (await _unitOfWork.User.IsUsernameTaken(registerUser.Username))
                {
                    response.IsSuccessful = false;
                    response.StatusCode = StatusCodes.Status406NotAcceptable;
                    response.Data = _mapper.Map<PostRegisterUserDTO, GetRegisterUserDTO>(registerUser);
                    response.Message = StaticData.usernameIsTakenMessage;
                    return response;
                }

                // Return bad response if the email address trying to be registered exists
                if (await _unitOfWork.User.IsEmailAddressTaken(registerUser.EmailAddress))
                {
                    response.IsSuccessful = false;
                    response.StatusCode = StatusCodes.Status406NotAcceptable;
                    response.Data = _mapper.Map<PostRegisterUserDTO, GetRegisterUserDTO>(registerUser);
                    response.Message = StaticData.emailAddressIsTakenMessage;
                    return response;
                }

                //Generate password hash that will be stored in database
                GeneratePasswordHash(registerUser.Password, out byte[] passwordSalt, out byte[] passwordHash);

                //Register user

                User user = new()
                {
                    Username = registerUser.Username.ToLower(),
                    EmailAddress = registerUser.EmailAddress.ToLower(),
                    PasswordSalt = passwordSalt,
                    PasswordHash = passwordHash,
                };

                await _unitOfWork.User.RegisterUser(user);
                await _unitOfWork.SaveAsync();

                response.StatusCode = StatusCodes.Status201Created;
                response.IsSuccessful = true;
                response.Data = _mapper.Map<PostRegisterUserDTO, GetRegisterUserDTO>(registerUser);
                response.Message = StaticData.createdSuccessfullyMessage;
                return response;


            }
            catch (Exception)
            {

                response.StatusCode = StatusCodes.Status500InternalServerError;
                response.IsSuccessful = false;
                response.Message = StaticData.internalServerErrorMessage;
                return response;
            }

        }

        private static void GeneratePasswordHash(string password, out byte[] passwordSalt, out byte[] passwordHash)
        {
            using HMACSHA512 hmac = new();
            passwordSalt = hmac.Key;
            passwordHash = hmac.ComputeHash(System.Text.Encoding.UTF8.GetBytes(password));
        }

        public async Task<ServiceResponse<string>> LoginUser(PostLoginUserDTO loginUser)
        {
            ServiceResponse<string> response = new();
            try
            {
                // the username or email address that is trying to login should exist
                if (!await _unitOfWork.User.DoesUserWithSaidUsernameOrEmailAddressExist(loginUser.UsernameOrEmailAddress))
                {
                    response.StatusCode = StatusCodes.Status401Unauthorized;
                    response.IsSuccessful = false;
                    response.Message = StaticData.userDoesNotExistMessage;
                    return response;

                }

                User userToAuthenticate = await _unitOfWork.User.GetAsync
                    (
                    u => u.Username.ToLower().Equals(loginUser.UsernameOrEmailAddress.ToLower())
                    || u.EmailAddress.ToLower().Equals(loginUser.UsernameOrEmailAddress.ToLower())
                    );

                // validate password
                if (!ComparePassword(loginUser.Password, userToAuthenticate.PasswordSalt!, userToAuthenticate.PasswordHash!))
                {
                    response.StatusCode = StatusCodes.Status401Unauthorized;
                    response.IsSuccessful = false;
                    response.Message = StaticData.invalidCredentialsMessage;
                    return response;
                }

                // Generate JWT

                response.Data = await CreateToken(userToAuthenticate);
                response.StatusCode = StatusCodes.Status200OK;
                response.IsSuccessful = true;
                response.Message = StaticData.userLoggedInSuccessfully;
                return response;
            }
            catch (Exception)
            {

                response.StatusCode = StatusCodes.Status500InternalServerError;
                response.IsSuccessful = false;
                response.Message = StaticData.internalServerErrorMessage;
                return response;
            }

        }

        private static bool ComparePassword(string password, byte[] passwordSalt, byte[] passwordHash)
        {
            using var hmac = new HMACSHA512(passwordSalt);
            var computeHash = hmac.ComputeHash(System.Text.Encoding.UTF8.GetBytes(password));
            return computeHash.SequenceEqual(passwordHash);
        }

        private async Task<string> CreateToken(User user)
        {
            List<Claim> claims = new()
            {
                new Claim(ClaimTypes.NameIdentifier, user.Id.ToString()),
                new Claim(ClaimTypes.Email, user.EmailAddress),
                new Claim(ClaimTypes.Name, user.Username),
                new Claim(ClaimTypes.Role, await _unitOfWork.User.GetUserRole(user.Username))
        };

            var key = new SymmetricSecurityKey(System.Text.Encoding.UTF8.GetBytes(_configuration.GetSection("JWT:Key").Value));

            var creds = new SigningCredentials(key, SecurityAlgorithms.HmacSha512Signature);

            var token = new JwtSecurityToken(
                claims: claims,
                expires: DateTime.Now.AddDays(1),
                signingCredentials: creds
                );

            var jwt = new JwtSecurityTokenHandler().WriteToken(token);

            return jwt;

        }


    }
}
