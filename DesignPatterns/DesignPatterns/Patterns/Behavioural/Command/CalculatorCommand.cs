namespace DesignPatterns.Patterns.Behavioural.Command
{
    public abstract class CalculatorCommand
    {
        protected Calculator calculator;

        public CalculatorCommand(Calculator calculator)
        {
            this.calculator = calculator;
        }

        public abstract void Execute();
    }
}