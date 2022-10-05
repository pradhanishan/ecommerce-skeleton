using Ecommerce.DataAccess.Repositories.IRepositories;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Ecommerce.DataAccess.Repositories.UnitsOfWork
{
    public interface IUnitOfWork
    {
        public IProductCategoryRepository ProductCategory { get; }

        Task SaveAsync();

    }
}
