using Ecommerce.Models.DTOS.User;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Ecommerce.Services.Server.AuthServices
{
    public interface IAuthService
    {
        Task<ServiceResponse<GetRegisterUserDTO>> RegisterUser(PostRegisterUserDTO registerUser);
    }
}
