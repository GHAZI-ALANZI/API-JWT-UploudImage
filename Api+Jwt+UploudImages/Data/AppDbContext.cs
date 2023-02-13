using Microsoft.EntityFrameworkCore;

namespace Api_Jwt_UploudImages.Data
{
   
        public class AppDbContext : DbContext
        {
            public AppDbContext(DbContextOptions<AppDbContext> options) : base(options)
            {

            }


        }
    }

