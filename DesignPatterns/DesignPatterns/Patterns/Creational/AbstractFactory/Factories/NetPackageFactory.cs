﻿using DesignPatterns.Patterns.Creational.AbstractFactory.Products;
using System;
using System.Collections.Generic;
using System.Text;

namespace DesignPatterns.Patterns.Creational.AbstractFactory.Factories
{
    public abstract class NetPackageFactory
    {
        protected string name;

        public string Name
        {
            get
            {
                return this.name;
            }
        }

        public abstract CapProduct CreateCap();
        public abstract LineSpeedProduct CreateLineSpeed();
    }
}
