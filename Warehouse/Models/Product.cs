using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Web;

namespace Warehouse.Models
{
    public class Product
    {
        public int Id { get; set; }

        [Required]
        [StringLength(100, MinimumLength = 3)]
        public string Name { get; set; }

        [Range(0, int.MaxValue, ErrorMessage = "The price can't be less than zero")]
        public int Price { get; set; }
        public string Category { get; set; }

        [Range(0, int.MaxValue, ErrorMessage = "The count can't be less than zero")]
        public int Count { get; set; }

        [Display(Name = "Product Description")]
        public string Description { get; set; }
    }
}
