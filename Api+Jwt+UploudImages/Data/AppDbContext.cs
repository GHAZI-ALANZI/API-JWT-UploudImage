using Api_Jwt_UploudImages.Data.Models;
using Microsoft.EntityFrameworkCore;

namespace Api_Jwt_UploudImages.Data
{
   
        public class AppDbContext : DbContext
        {
            public AppDbContext(DbContextOptions<AppDbContext> options) : base(options)
            {

            }
        public DbSet<Category> Categories { get; set; }
        public DbSet<Item> Items { get; set; }
        public DbSet<Order> Orders { get; set; }

        public DbSet<OrderItem> OrderItems { get; set; }

    }
    }

