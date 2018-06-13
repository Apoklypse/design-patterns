using System;
using System.Collections.Generic;
using System.Text;

namespace DesignPatterns.Patterns.Creational.AbstractFactory.Products
{
    public abstract class CapProduct
    {
        protected string cap;

        public string Cap
        {
            get
            {
                return this.cap;
            }
        }
    }
}
