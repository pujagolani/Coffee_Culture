using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using System.ComponentModel.DataAnnotations;

namespace Coffee_Culture.Models
{
    public class CoffeeBean
    {
        public int Id { get; set; }
        public string Types_Of_Coffee { get; set; }
        [DataType(DataType.Date)]
        public DateTime Manufacture_Date { get; set; }
        public string Production_Country { get; set; }
        public string Roasting { get; set; }
        public decimal Price { get; set; }
        public string Description_Of_Product { get; set; }
        public string Packaging { get; set; }
    }
}
