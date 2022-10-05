using AutoMapper;
using Ecommerce.Constants;
using Ecommerce.DataAccess.Repositories.UnitsOfWork;
using Ecommerce.Models.DTOS.User;
using Ecommerce.Models.Entities;
using Microsoft.AspNetCore.Http;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Security.Cryptography;
using System.Text;
using System.Threading.Tasks;

namespace Ecommerce.Services.Server.AuthServices
{
    public sealed class AuthService : IAuthService
    {
        private readonly IUnitOfWork _unitOfWork;
        private readonly IMapper _mapper;

        public AuthService(IUnitOfWork unitOfWork, IMapper mapper)
        {
            _unitOfWork = unitOfWork;
            _mapper = mapper;
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

    }
}
