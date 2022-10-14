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

        [StringLength(50, MinimumLength = 3)]
        [Required]
        public string Types_Of_Coffee { get; set; }

        [Display(Name = "Manufacture_Date")]
        [DataType(DataType.Date)]
        public DateTime Manufacture_Date { get; set; }

        [RegularExpression(@"^[A-Z]+[a-zA-Z\s]*$")]
        [Required]
        [StringLength(20)]
        public string Production_Country { get; set; }

        [RegularExpression(@"^[A-Z]+[a-zA-Z\s]*$")]
        [Required]
        [StringLength(20)]
        public string Roasting { get; set; }

        [Range(1, 100)]
        [DataType(DataType.Currency)]
        [Column(TypeName = "decimal(18,2)")]
        public decimal Price { get; set; }
        public string Description_Of_Product { get; set; }

        [RegularExpression(@"^[A-Z]+[a-zA-Z\s]*$")]
        [Required]
        [StringLength(20)]
        public string Packaging { get; set; }

        [Range(1, 5)]
        public int Rating { get; set; }
    }
}
