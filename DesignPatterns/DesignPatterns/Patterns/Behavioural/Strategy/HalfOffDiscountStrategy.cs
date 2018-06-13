namespace DesignPatterns.Patterns.Behavioural.Strategy
{
    public class HalfOffDiscountStrategy : IDiscountStrategy
    {
        public double MakeDeduction(double amount)
        {
            return amount * 0.5;
        }
    }
}