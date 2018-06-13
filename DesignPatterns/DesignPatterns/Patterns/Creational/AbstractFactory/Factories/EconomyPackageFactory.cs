using DesignPatterns.Patterns.Creational.AbstractFactory.Products;
using System;
using System.Collections.Generic;
using System.Text;

namespace DesignPatterns.Patterns.Creational.AbstractFactory.Factories
{
    public class EconomyPackageFactory : NetPackageFactory
    {
        public EconomyPackageFactory()
        {
            this.name = "Economy Package";
        }

        public override CapProduct CreateCap()
        {
            return new EconomyCapProduct();
        }

        public override LineSpeedProduct CreateLineSpeed()
        {
            return new EconomyLineSpeedProduct();
        }
    }
}
