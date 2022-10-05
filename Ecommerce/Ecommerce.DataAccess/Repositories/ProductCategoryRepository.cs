using Ecommerce.DataAccess.ApplicationDataContext;
using Ecommerce.DataAccess.Repositories.IRepositories;
using Ecommerce.Models.Entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Ecommerce.DataAccess.Repositories
{
    public sealed class ProductCategoryRepository : Repository<ProductCategory>, IProductCategoryRepository
    {
        public ProductCategoryRepository(ApplicationDbContext db) : base(db)
        {
        }
    }
}
