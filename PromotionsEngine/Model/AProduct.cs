using PromotionsEngine.Interfaces;
using System;
using System.Collections.Generic;
using System.Text;

namespace PromotionsEngine.Models
{
    public class AProduct : IPack
    {
        public Product Product { get; set; }
        
        public int ProductsCount { get; set; }
        public int GetPrice() => 130 * (ProductsCount / 3) + 50 * (ProductsCount % 3);
    }
}
