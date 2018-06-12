using System;

namespace DesignPatterns.Patterns.Behavioural.Command
{
    /// <summary>
    /// This class is the Receiver for commands
    /// </summary>
    public class Calculator
    {
        public void Add(double leftHandSide, double rightHandSide)
        {
            Console.WriteLine($"{ leftHandSide } + { rightHandSide } = { leftHandSide + rightHandSide }");
        }

        public void Subtract(double leftHandSide, double rightHandSide)
        {
            Console.WriteLine($"{ leftHandSide } - { rightHandSide } = { leftHandSide - rightHandSide }");
        }
    }
}
