using PromotionsEngine.Interfaces;
using System;
using System.Collections.Generic;
using System.Text;

namespace PromotionsEngine.Models
{
    public class CProduct : IPack
    {
        public Product Product { get; set; }
        
        public int ProductsCount { get; set; }
        public int GetPrice() => 20;
    }
}
