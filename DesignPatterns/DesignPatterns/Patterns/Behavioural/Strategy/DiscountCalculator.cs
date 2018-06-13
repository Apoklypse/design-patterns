namespace DesignPatterns.Patterns.Behavioural.Strategy
{
    public class DiscountCalculator
    {
        public double ApplyDiscount(double amount, IDiscountStrategy strategy)
        {
            return strategy.MakeDeduction(amount);
        }
    }
}