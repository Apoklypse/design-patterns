namespace DesignPatterns.Patterns.Behavioural.Strategy
{
    public interface IDiscountStrategy
    {
        double MakeDeduction(double amount);
    }
}