using Ecommerce.Constants;
using Ecommerce.Models.DTOS.ProductCategory;
using Ecommerce.Models.DTOS.User;
using Ecommerce.Services.Server;
using Ecommerce.Services.Server.AuthServices;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;

namespace Ecommerce.Server.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class AuthController : ControllerBase
    {
        private readonly IAuthService _authService;

        public AuthController(IAuthService authService)
        {
            _authService = authService;
        }

        /// <summary>
        ///  Register a new user
        /// </summary>
        /// <param name="registerUser"></param>
        [HttpPost("register")]

        public async Task<ActionResult<ServiceResponse<GetRegisterUserDTO>>> Register(PostRegisterUserDTO registerUser)
        {
            if (!ModelState.IsValid)
            {
                return BadRequest();
            }
            var response = await _authService.RegisterUser(registerUser);
            return response.StatusCode switch
            {
                201 => (ActionResult<ServiceResponse<GetRegisterUserDTO>>)CreatedAtAction("Register", response),
                406 => (ActionResult<ServiceResponse<GetRegisterUserDTO>>)BadRequest(response),
                _ => (ActionResult<ServiceResponse<GetRegisterUserDTO>>)Problem(detail: response.Message, statusCode: StatusCodes.Status500InternalServerError, title: response.Message),
            };

        }

    }
}
