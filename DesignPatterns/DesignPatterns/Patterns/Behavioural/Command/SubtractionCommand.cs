namespace DesignPatterns.Patterns.Behavioural.Command
{
    public class SubtractionCommand : CalculatorCommand
    {
        public SubtractionCommand(Calculator calculator, double leftHandSide, double rightHandSide)
            : base(calculator)
        {
            this.LeftHandSide = leftHandSide;
            this.RightHandSide = rightHandSide;
        }

        public double LeftHandSide { get; set; }

        public double RightHandSide { get; set; }

        public override void Execute()
        {
            this.calculator.Subtract(LeftHandSide, RightHandSide);
        }
    }
}