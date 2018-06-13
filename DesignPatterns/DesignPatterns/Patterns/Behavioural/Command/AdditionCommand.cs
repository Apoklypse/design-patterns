namespace DesignPatterns.Patterns.Behavioural.Command
{
    public class AdditionCommand : CalculatorCommand
    {
        public AdditionCommand(Calculator calculator, double leftHandSide, double rightHandSide)
            : base(calculator)
        {
            this.LeftHandSide = leftHandSide;
            this.RightHandSide = rightHandSide;
        }

        public double LeftHandSide { get; set; }

        public double RightHandSide { get; set; }

        public override void Execute()
        {
            this.calculator.Add(LeftHandSide, RightHandSide);
        }
    }
}