using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.EntityFrameworkCore;
using Coffee_Culture.Models;


namespace Coffee_Culture.Data
{
    public class Coffee_CultureContext : DbContext
    {
        public Coffee_CultureContext(DbContextOptions<Coffee_CultureContext> options)
            : base(options)
        {

        }
        public DbSet<CoffeeBean> CoffeeBean { get; set; }
    }
}
