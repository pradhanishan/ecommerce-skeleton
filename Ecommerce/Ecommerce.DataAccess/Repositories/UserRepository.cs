using Ecommerce.Constants;
using Ecommerce.DataAccess.ApplicationDataContext;
using Ecommerce.DataAccess.Repositories.IRepositories;
using Ecommerce.Models.Entities;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Net.Mail;
using System.Text;
using System.Threading.Tasks;

namespace Ecommerce.DataAccess.Repositories
{
    public sealed class UserRepository : Repository<User>, IUserRepository
    {
        private readonly ApplicationDbContext _db;
        public UserRepository(ApplicationDbContext db) : base(db)
        {
            _db = db;
        }

        public async Task<bool> IsEmailAddressTaken(string emailAddress)
        {
            return await _db.Users!.AnyAsync(u => u.EmailAddress.ToLower().Equals(emailAddress.ToLower()));
        }

        public async Task<bool> IsUsernameTaken(string username)
        {
            return await _db.Users!.AnyAsync(u => u.Username.ToLower().Equals(username.ToLower()));
        }

        public async Task<User> RegisterUser(User registerUser)
        {
            await _db.Users!.AddAsync(registerUser);
            await _db.SaveChangesAsync();
            User registeredUser = _db.Users.FirstOrDefault(x => x.Username.ToLower().Equals(registerUser.Username.ToLower()))!;
            Role role = await _db.Roles.FirstOrDefaultAsync(r => r.Name.ToLower().Equals(StaticData.userRole.ToLower()));

            UserRole userRole = new()
            {
                Role = role,
                User = registeredUser,
                RoleId = role.Id,
                UserId = registeredUser.Id,
            };

            await _db.UserRoles.AddAsync(userRole);
            await _db.SaveChangesAsync();

            return registeredUser;

        }



    }
}
