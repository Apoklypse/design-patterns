using DesignPatterns.Patterns.Creational.AbstractFactory;
using DesignPatterns.Patterns.Creational.AbstractFactory.Factories;
using DesignPatterns.Utility;
using System;
using System.Collections.Generic;
using System.Text;

namespace DesignPatterns.Clients
{
    public class AbstractFactoryClient : Client
    {
        public AbstractFactoryClient()
        {
            this.Name = "Abstract Factory";
            this.Category = PatternCategories.Creational;
        }

        protected override void PerfomAction()
        {
            var factory = new BusinessPackageFactory();
            var packageBuilder = new NetPackageBuilder(factory);

            packageBuilder.PrintPackageDetails();
        }
    }
}
