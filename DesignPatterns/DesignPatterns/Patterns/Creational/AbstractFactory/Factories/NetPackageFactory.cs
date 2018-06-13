using DesignPatterns.Patterns.Creational.AbstractFactory.Products;

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