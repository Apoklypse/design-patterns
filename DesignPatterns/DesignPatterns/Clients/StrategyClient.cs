using DesignPatterns.Patterns.Behavioural.Strategy;
using DesignPatterns.Utility;
using System;

namespace DesignPatterns.Clients
{
    public class StrategyClient : Client
    {
        public StrategyClient()
        {
            this.Name = "Strategy";
            this.Category = PatternCategories.Behavioural;
        }

        protected override void PerfomAction()
        {
            var discountCalculator = new DiscountCalculator();
            var halfOffDiscount = new HalfOffDiscountStrategy() as IDiscountStrategy;
            var fiveFingerDiscount = new FiveFingerDiscountStrategy() as IDiscountStrategy;
            var amount = 100;

            var discount = discountCalculator.ApplyDiscount(amount, halfOffDiscount);

            Console.WriteLine($"Full price: R{ amount }");
            Console.WriteLine($"Half-off: R{ discount }");

            discount = discountCalculator.ApplyDiscount(100, fiveFingerDiscount);

            Console.WriteLine($"Five-finger discount: R{ discount }");
        }
    }
}