using PromotionsEngine.Interfaces;
using System;
using System.Collections.Generic;
using System.Text;
using System.Linq;
using PromotionsEngine.Models;

namespace PromotionsEngine.Business
{
    public class Order : IPack
    {
        readonly AProduct aPack = new AProduct();
        readonly BProduct bPack = new BProduct();
        readonly XProduct xPack = new XProduct();

        List<IPack> packs = new List<IPack>();

        public Order()
        {
            packs.Add(aPack);
            packs.Add(bPack);
            packs.Add(xPack);
        }
        public int GetPrice()
        {
            int result=0;
            foreach(var pack in packs)
            {
                result += pack.GetPrice();
            }

            return result;
        }

        public void AddProduct(Product p)
        {
            switch (p.SkuId)
            {
                case 'A':
                    {
                        aPack.ProductsCount++;
                        break;
                    }
                case 'B':
                    {
                        bPack.ProductsCount++;
                        break;
                    }
                case 'C':
                    {
                        xPack.ProductsCCount++;
                        break;
                    }
                case 'D':
                    {
                        xPack.ProductsDCount++;
                        break;
                    }

            }
        }
    }
}
