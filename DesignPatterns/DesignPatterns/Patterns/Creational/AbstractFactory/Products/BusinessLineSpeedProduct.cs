using System;
using System.Collections.Generic;
using System.Text;

namespace DesignPatterns.Patterns.Creational.AbstractFactory.Products
{
    public class BusinessLineSpeedProduct : LineSpeedProduct
    {
        public BusinessLineSpeedProduct()
        {
            this.speed = "100Mb/s";
        }
    }
}
