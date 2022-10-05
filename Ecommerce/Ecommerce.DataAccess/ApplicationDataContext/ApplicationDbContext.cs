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

        }

        public DbSet<ProductCategory> ProductCategories { get; set; }

    }
}
