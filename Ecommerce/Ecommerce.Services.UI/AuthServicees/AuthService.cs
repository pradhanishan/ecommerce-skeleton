using Ecommerce.Constants;
using Ecommerce.Models.DTOS.User;
using Microsoft.AspNetCore.Http;
using Newtonsoft.Json;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Net.Http.Json;
using System.Text;
using System.Text.Json.Serialization;
using System.Threading.Tasks;


namespace Ecommerce.Services.UI.AuthServicees
{
    public sealed class AuthService : IAuthService
    {
        private readonly HttpClient _httpClient;

        public AuthService(HttpClient httpClient)
        {
            _httpClient = httpClient;
        }
        public async Task<ServiceResponse<string>> Login(PostLoginUserDTO loginUser)
        {
            HttpResponseMessage response = await _httpClient.PostAsJsonAsync("/api/auth/login", loginUser);
            string responseString = response.Content.ReadAsStringAsync().Result;
            ServiceResponse<string>? responseData = JsonConvert.DeserializeObject<ServiceResponse<string>>(responseString);
            if (responseData == null)
            {
                return new ServiceResponse<string>()
                {
                    IsSuccessful = false,
                    StatusCode = StatusCodes.Status500InternalServerError,
                    Message = StaticData.internalServerErrorMessage,
                };
            }
            return responseData;
        }

        public async Task<ServiceResponse<GetRegisterUserDTO>> Register(PostRegisterUserDTO registerUser)
        {
            HttpResponseMessage response = await _httpClient.PostAsJsonAsync("/api/auth/register", registerUser);
            string responseString = response.Content.ReadAsStringAsync().Result;
            ServiceResponse<GetRegisterUserDTO>? responseData = JsonConvert.DeserializeObject<ServiceResponse<GetRegisterUserDTO>>(responseString);
            if (responseData == null)
            {
                return new ServiceResponse<GetRegisterUserDTO>()
                {
                    IsSuccessful = false,
                    StatusCode = StatusCodes.Status500InternalServerError,
                    Message = StaticData.internalServerErrorMessage,
                };
            }
            return responseData;

        }
    }
}
