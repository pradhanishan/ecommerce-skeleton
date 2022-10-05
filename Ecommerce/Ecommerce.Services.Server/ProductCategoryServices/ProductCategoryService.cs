using AutoMapper;
using Ecommerce.Constants;
using Ecommerce.DataAccess.Repositories.UnitsOfWork;
using Ecommerce.Models.DTOS.ProductCategory;
using Ecommerce.Models.Entities;
using Microsoft.AspNetCore.Http;

namespace Ecommerce.Services.Server.ProductCategoryServices
{
    public sealed class ProductCategoryService : IProductCategoryService
    {
        private readonly IUnitOfWork _unitOfWork;
        private readonly IMapper _mapper;

        public ProductCategoryService(IUnitOfWork unitOfWork, IMapper mapper)
        {
            _unitOfWork = unitOfWork;
            _mapper = mapper;
        }

        public async Task<ServiceResponse<IEnumerable<GetProductCategoryDTO>>> GetProductCategories()
        {
            ServiceResponse<IEnumerable<GetProductCategoryDTO>> response = new();

            try
            {
                IEnumerable<ProductCategory> productCategories = await _unitOfWork.ProductCategory.GetAllAsync();
                response.StatusCode = StatusCodes.Status200OK;
                response.IsSuccessful = true;
                response.Data = _mapper.Map<IEnumerable<ProductCategory>, IEnumerable<GetProductCategoryDTO>>(productCategories);
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
    }
}
