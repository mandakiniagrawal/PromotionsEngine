using PromotionsEngine.Interfaces;

namespace PromotionsEngine.Models
{
    public class DProduct : IPack
    {
        public Product Product { get; set; }
        public int ProductsCount { get; set; }
        public int GetPrice() => 15;
    }
}
