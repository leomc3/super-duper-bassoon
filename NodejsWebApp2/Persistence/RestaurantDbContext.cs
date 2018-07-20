using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.EntityFrameworkCore;
using NodejsWebApp2.Models;

namespace NodejsWebApp2.Persistence
{
    public class RestaurantDbContext : DbContext
    {
        //public restaurantDbContext(string connectionString) : base(connectionString)
        public RestaurantDbContext(DbContextOptions<RestaurantDbContext> options) : base(options)

        {
            //System.ConfigurationManager
        }

        public DbSet<Make> Makes { get; set; }
          
    }
}
