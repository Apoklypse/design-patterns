using DesignPatterns.Patterns.Creational.AbstractFactory.Factories;
using DesignPatterns.Patterns.Creational.AbstractFactory.Products;
using System;
using System.Collections.Generic;
using System.Text;

namespace DesignPatterns.Patterns.Creational.AbstractFactory
{
    public class NetPackageBuilder
    {
        private string name;
        private CapProduct cap;
        private LineSpeedProduct lineSpeed;

        public NetPackageBuilder(NetPackageFactory factory)
        {
            this.name = factory.Name;
            this.cap = factory.CreateCap();
            this.lineSpeed = factory.CreateLineSpeed();
        }

        public void PrintPackageDetails()
        {
            String output = $"{ this.name } Details:\n";

            output += $"Cap: { this.lineSpeed.Speed }\n";
            output += $"Line Speed: { this.cap.Cap }\n";

            Console.WriteLine(output);
        }
    }
}
