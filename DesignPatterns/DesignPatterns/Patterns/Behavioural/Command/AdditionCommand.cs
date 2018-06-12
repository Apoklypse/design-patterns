using System;
using System.Collections.Generic;
using System.Text;

namespace DesignPatterns.Patterns.Behavioural.Command
{
    public class AdditionCommand : CalculatorCommand
    {
        public double LeftHandSide { get; set; }

        public double RightHandSide { get; set; }

        public AdditionCommand(Calculator calculator, double leftHandSide, double rightHandSide)
            : base(calculator)
        {
            this.LeftHandSide = leftHandSide;
            this.RightHandSide = rightHandSide;
        }

        public override void Execute()
        {
            this.calculator.Add(LeftHandSide, RightHandSide);
        }
    }
}
