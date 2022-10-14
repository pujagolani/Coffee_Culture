using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc.Rendering;
namespace Coffee_Culture.Models
{
    public class CoffeeRoastingViewModel
    {
        public List<CoffeeBean> CoffeeBeans { get; set; }
        public SelectList Roastings { get; set; }
        public string CoffeeRoasting { get; set; }
        public string SearchString { get; set; }
    }
}
