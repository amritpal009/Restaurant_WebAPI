using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.EntityFrameworkCore;
using Restaurant_WebAPI.Models;

namespace Restaurant_WebAPI.Data
{
    public class Restaurant_WebAPIContext : DbContext
    {
        public Restaurant_WebAPIContext (DbContextOptions<Restaurant_WebAPIContext> options)
            : base(options)
        {
        }

        public DbSet<Restaurant_WebAPI.Models.Menu> Menu { get; set; }
    }
}
