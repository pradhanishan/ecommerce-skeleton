using Ecommerce.DataAccess.ApplicationDataContext;
using Ecommerce.DataAccess.Repositories.IRepositories;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Linq.Expressions;
using System.Text;
using System.Threading.Tasks;

namespace Ecommerce.DataAccess.Repositories
{
    public class Repository<T> : IRepository<T> where T : class
    {
        private readonly ApplicationDbContext _db;
        public Repository(ApplicationDbContext db)
        {
            _db = db;
        }

        public async Task<T> CreateAsync(T Entity)
        {
            await _db.Set<T>().AddAsync(Entity);
            return Entity;
        }

        public async Task<IEnumerable<T>> GetAllAsync()
        {
            IEnumerable<T> result = await _db.Set<T>().ToListAsync();
            return result;
        }

        public async Task<T> GetAsync(Expression<Func<T, bool>> filter)
        {
            IQueryable<T> query = _db.Set<T>();
            query = query.Where(filter);
            return await query.FirstOrDefaultAsync();
        }
    }
}
