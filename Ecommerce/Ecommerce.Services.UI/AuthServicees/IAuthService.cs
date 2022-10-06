using Ecommerce.Models.DTOS.User;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Ecommerce.Services.UI.AuthServicees
{
    public interface IAuthService
    {
        Task<ServiceResponse<GetRegisterUserDTO>> Register(PostRegisterUserDTO registerUser);
        Task<ServiceResponse<string>> Login(PostLoginUserDTO loginUser);


    }
}
