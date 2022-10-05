using Ecommerce.Models.DTOS.ProductCategory;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Ecommerce.Services.Server.ProductCategoryServices
{
    public interface IProductCategoryService
    {
        Task<ServiceResponse<IEnumerable<GetProductCategoryDTO>>> GetProductCategories();
    }
}
