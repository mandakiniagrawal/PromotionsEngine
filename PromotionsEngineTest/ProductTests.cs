using NUnit.Framework;
using PromotionsEngine.Business;
using PromotionsEngine.Models;

namespace PromotionsEngineTest
{
    public class ProductTests
    {
        [Test]
        public void TestMethodPass1()
        {
            Order order1 = new Order();
            order1.AddProduct(new Product { SkuId = 'A', Price = 50 });
            order1.AddProduct(new Product { SkuId = 'B', Price = 30 });
            order1.AddProduct(new Product { SkuId = 'C', Price = 20 });
            order1.AddProduct(new Product { SkuId = 'D', Price = 15 });
            Assert.AreEqual(110, order1.GetPrice());
        }

        [Test]
        public void TestMethodPass2()
        {
            Order order1 = new Order();
            order1.AddProduct(new Product { SkuId = 'A', Price = 50 });
            order1.AddProduct(new Product { SkuId = 'A', Price = 50 });
            order1.AddProduct(new Product { SkuId = 'A', Price = 50 });
            order1.AddProduct(new Product { SkuId = 'B', Price = 30 });
            order1.AddProduct(new Product { SkuId = 'C', Price = 20 });
            order1.AddProduct(new Product { SkuId = 'D', Price = 15 });
            Assert.AreEqual(190, order1.GetPrice());
        }

        [Test]
        public void TestMethodPass3()
        {
            Order order1 = new Order();
            order1.AddProduct(new Product { SkuId = 'A', Price = 50 });
            order1.AddProduct(new Product { SkuId = 'A', Price = 50 });
            order1.AddProduct(new Product { SkuId = 'A', Price = 50 });
            order1.AddProduct(new Product { SkuId = 'B', Price = 30 });
            order1.AddProduct(new Product { SkuId = 'B', Price = 30 });
            order1.AddProduct(new Product { SkuId = 'B', Price = 30 });
            order1.AddProduct(new Product { SkuId = 'C', Price = 20 });
            Assert.AreEqual(225, order1.GetPrice());
        }

        [Test]
        public void TestMethodPass4()
        {
            Order order1 = new Order();

            Assert.AreEqual(0, order1.GetPrice());
        }
    }
}