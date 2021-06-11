using PromotionsEngine.Interfaces;

namespace PromotionsEngine.Models
{
    class XProduct : IPack
    {
        public XProduct()
        {
            cProduct = new CProduct();
            dProduct = new DProduct();
        }

        readonly CProduct cProduct;
        readonly DProduct dProduct;
        public int ProductsCCount { get; set; }
        public int ProductsDCount { get; set; }
        public int GetPrice()
        {
            int promotionPrice;
            if (ProductsCCount > ProductsDCount)
            {
                promotionPrice = ProductsDCount;
                ProductsCCount -= ProductsDCount;
            }
            else if (ProductsCCount < ProductsDCount)
            {
                promotionPrice = ProductsDCount;
                ProductsDCount -= ProductsCCount;
            }
            else
            {
                promotionPrice = ProductsDCount;
                ProductsCCount = ProductsDCount = 0;
            }
            var x = 30 * promotionPrice + cProduct.GetPrice() * ProductsCCount + dProduct.GetPrice() * ProductsDCount;

            return x;
        }
    }
}
