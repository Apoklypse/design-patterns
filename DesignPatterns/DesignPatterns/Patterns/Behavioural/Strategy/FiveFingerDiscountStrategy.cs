using System;
using System.Collections.Generic;
using System.Text;

namespace DesignPatterns.Patterns.Behavioural.Strategy
{
    public class FiveFingerDiscountStrategy : IDiscountStrategy
    {
        public double MakeDeduction(double amount)
        {
            return 0;
        }
    }
}
