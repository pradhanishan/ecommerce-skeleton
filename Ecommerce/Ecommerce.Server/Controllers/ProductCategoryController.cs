using Ecommerce.Models.DTOS.ProductCategory;
using Ecommerce.Services.Server;
using Ecommerce.Services.Server.ProductCategoryServices;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using System.Reflection;

namespace Ecommerce.Server.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class ProductCategoryController : ControllerBase
    {

        private readonly IProductCategoryService _productCategoryService;
        public ProductCategoryController(IProductCategoryService productCategoryService)
        {
            _productCategoryService = productCategoryService;
        }

        [HttpGet("getproductgategories")]

        public async Task<ActionResult<ServiceResponse<GetProductCategoryDTO>>> Get()
        {
            var response = await _productCategoryService.GetProductCategories();

            return response.StatusCode switch
            {
                200 => (ActionResult<ServiceResponse<GetProductCategoryDTO>>)Ok(response),
                _ => (ActionResult<ServiceResponse<GetProductCategoryDTO>>)Problem(detail: response.Message, statusCode: StatusCodes.Status500InternalServerError, title: response.Message),
            };

        }

    }
}
