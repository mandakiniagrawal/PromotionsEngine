using PromotionsEngine.Business;
using PromotionsEngine.Models;
using System;

namespace PromotionsEngine
{
    class Program
    {
        static void Main(string[] args)
        {
            Order order1 = new Order();
            order1.AddProduct(new Product { SkuId = 'A', Price = 50 });
            order1.AddProduct(new Product { SkuId = 'B', Price = 30 });
            order1.AddProduct(new Product { SkuId = 'C', Price = 20 });
            order1.AddProduct(new Product { SkuId = 'D', Price = 15 });
            Console.WriteLine(string.Format("Total price for Order 1 is {0}", order1.GetPrice()));
            Console.WriteLine("Hello World!");
        }
    }
}
