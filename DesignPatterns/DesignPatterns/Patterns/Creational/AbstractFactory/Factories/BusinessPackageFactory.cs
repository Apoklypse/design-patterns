using DesignPatterns.Patterns.Creational.AbstractFactory.Products;
using System;
using System.Collections.Generic;
using System.Text;

namespace DesignPatterns.Patterns.Creational.AbstractFactory.Factories
{
    public class BusinessPackageFactory : NetPackageFactory
    {
        public BusinessPackageFactory()
        {
            this.name = "Business Package";

        }

        public override CapProduct CreateCap()
        {
            return new BusinessCapProduct();
        }

        public override LineSpeedProduct CreateLineSpeed()
        {
            return new BusinessLineSpeedProduct();
        }
    }
}
