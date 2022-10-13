using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.EntityFrameworkCore;
using Coffee_Culture.Models;


namespace Coffee_Culture.Data
{
    public class CoffeeBeanContext : DbContext
    {
        public CoffeeBeanContext(DbContextOptions<CoffeeBeanContext> options)
            : base(options)
        {

        }
        public DbSet<CoffeeBean> Coffee { get; set; }
    }
}
