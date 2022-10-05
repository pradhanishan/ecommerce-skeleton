using Ecommerce.Models.Entities;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Ecommerce.DataAccess.ApplicationDataContext
{
    public sealed class ApplicationDbContext : DbContext
    {
        public ApplicationDbContext(DbContextOptions<ApplicationDbContext> options) : base(options)
        {

        }

        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            modelBuilder.Entity<ProductCategory>().HasIndex(pc => pc.Name).IsUnique();
            modelBuilder.Entity<Role>().HasIndex(r => r.Name).IsUnique();
            modelBuilder.Entity<UserRole>().HasIndex(ur => new { ur.RoleId, ur.UserId }).IsUnique();

            // Seed Admin Data

            modelBuilder.Entity<Role>().HasData(
                new Role { Id = 1, Name = "Admin" },
                new Role { Id = 2, Name = "User" }
                );


            modelBuilder.Entity<ProductCategory>().HasData
                (
                    new ProductCategory { Id = 1, Name = "Fashion" },
                    new ProductCategory { Id = 2, Name = "Mobiles and Tablets" },
                    new ProductCategory { Id = 3, Name = "Consumer Electronics" },
                    new ProductCategory { Id = 4, Name = "Books" },
                    new ProductCategory { Id = 5, Name = "Movie Tickets" },
                    new ProductCategory { Id = 6, Name = "Baby Products" },
                    new ProductCategory { Id = 7, Name = "Groceries" },
                    new ProductCategory { Id = 8, Name = "Food Takeaway/Delivery" },
                    new ProductCategory { Id = 9, Name = "Home Furnishings" },
                    new ProductCategory { Id = 10, Name = "Jewelry" }
                );

            modelBuilder.Entity<User>().HasIndex(u => u.Username).IsUnique();
            modelBuilder.Entity<User>().HasIndex(u => u.EmailAddress).IsUnique();

        }

        public DbSet<ProductCategory>? ProductCategories { get; set; }
        public DbSet<User>? Users { get; set; }

        public DbSet<Role>? Roles { get; set; }

        public DbSet<UserRole>? UserRoles { get; set; }


    }
}
