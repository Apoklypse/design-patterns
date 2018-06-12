namespace DesignPatterns.Patterns.Behavioural.Command
{
    public class SubtractionCommand : CalculatorCommand
    {
        public double LeftHandSide { get; set; }

        public double RightHandSide { get; set; }

        public SubtractionCommand(Calculator calculator, double leftHandSide, double rightHandSide)
            : base(calculator)
        {
            this.LeftHandSide = leftHandSide;
            this.RightHandSide = rightHandSide;
        }

        public override void Execute()
        {
            this.calculator.Subtract(LeftHandSide, RightHandSide);
        }
    }
}
