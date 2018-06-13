namespace DesignPatterns.Patterns.Creational.AbstractFactory.Products
{
    public abstract class LineSpeedProduct
    {
        protected string speed;

        public string Speed
        {
            get
            {
                return this.speed;
            }
        }
    }
}
