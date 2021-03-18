using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace TenderSystem.Models
{
    public class Product
    {
        public int ProductId { get; set; }
        public string ProductNo { get; set; }
        public string Description { get; set; }
        public int ProductQuantity { get; set; }
        public decimal ProductPrice { get; set; }
    }
}
