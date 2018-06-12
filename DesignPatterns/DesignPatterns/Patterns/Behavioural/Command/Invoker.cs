namespace DesignPatterns.Patterns.Behavioural.Command
{
    public class Invoker
    {
        public CalculatorCommand Command { get; set; }

        public void ExecuteCommand()
        {
            this.Command.Execute();
        }
    }
}
