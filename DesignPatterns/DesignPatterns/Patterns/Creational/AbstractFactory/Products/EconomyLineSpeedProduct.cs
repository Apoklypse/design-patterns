using System;
using System.Collections.Generic;
using System.Text;

namespace DesignPatterns.Patterns.Creational.AbstractFactory.Products
{
    public class EconomyLineSpeedProduct : LineSpeedProduct
    {
        public EconomyLineSpeedProduct()
        {
            this.speed = "20Mb/s";
        }
    }
}
