using System;
using System.Collections.Generic;
using System.Text;

namespace DesignPatterns.Patterns.Creational.AbstractFactory.Products
{
    public class EconomyCapProduct : CapProduct
    {
        public EconomyCapProduct()
        {
            this.cap = "1TB/month";
        }
    }
}
