using System;
using System.Collections.Generic;
using System.Text;

namespace DesignPatterns.Patterns.Creational.AbstractFactory.Products
{
    public class BusinessCapProduct : CapProduct
    {
        public BusinessCapProduct()
        {
            this.cap = "500MB/month";
        }
    }
}
