using System;
using System.Collections.Generic;
using System.Text;

namespace DesignPatterns.Patterns.Behavioural.Strategy
{
    public interface IDiscountStrategy
    {
        double MakeDeduction(double amount);
    }
}
