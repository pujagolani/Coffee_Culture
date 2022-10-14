using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace Coffee_Culture.Models
{
    public class CoffeeBean
    {
        public int Id { get; set; }
        public string Types_Of_Coffee { get; set; }
        [Display(Name = "Manufacture_Date")]
        [DataType(DataType.Date)]
        public DateTime Manufacture_Date { get; set; }
        public string Production_Country { get; set; }
        public string Roasting { get; set; }
        [Column(TypeName = "decimal(18,2)")]
        public decimal Price { get; set; }
        public string Description_Of_Product { get; set; }
        public string Packaging { get; set; }
    }
}
