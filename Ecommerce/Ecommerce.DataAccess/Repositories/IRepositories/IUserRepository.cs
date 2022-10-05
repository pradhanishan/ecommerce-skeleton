using Ecommerce.Models.Entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Ecommerce.DataAccess.Repositories.IRepositories
{
    public interface IUserRepository : IRepository<User>
    {
        Task<User> RegisterUser(User registerUser);

        Task<bool> IsUsernameTaken(string username);

        Task<bool> IsEmailAddressTaken(string emailAddress);

    }
}
