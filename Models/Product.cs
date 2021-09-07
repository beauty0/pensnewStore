using System;
using System.Collections.Generic;
using System.Linq;
using System.ComponentModel.DataAnnotations;
using System.Threading.Tasks;

namespace pensnewStore.Models
{
    public class Product
    {
        [Required]
        public int ProductId { get; set; }

        public int CustomerId { get; set; }
        public string Pen_type { get; set; }
        public int Quantity { get; set; }
        public decimal Price { get; set; }
        // navigation property//

    }
}
