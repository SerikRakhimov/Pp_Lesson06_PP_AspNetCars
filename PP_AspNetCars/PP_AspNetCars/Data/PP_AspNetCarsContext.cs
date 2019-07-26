using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.EntityFrameworkCore;

namespace PP_AspNetCars.Models
{
    public class PP_AspNetCarsContext : DbContext
    {
        public PP_AspNetCarsContext (DbContextOptions<PP_AspNetCarsContext> options)
            : base(options)
        {
        }

        public DbSet<PP_AspNetCars.Models.Car> Car { get; set; }
    }
}
