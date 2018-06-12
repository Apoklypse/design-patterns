using DesignPatterns.Patterns.Behavioural.Command;
using DesignPatterns.Utility;

namespace DesignPatterns.Clients
{
    public class CommandClient : Client
    {
        public CommandClient()
        {
            this.Name = "Command";
            this.Category = PatternCategories.Behavioural.ToString();
        }

        protected override void PerfomAction()
        {
            var calculator = new Calculator();
            var invoker = new Invoker();

            invoker.Command = new AdditionCommand(calculator, 8, 7);
            invoker.ExecuteCommand();

            invoker.Command = new SubtractionCommand(calculator, 15, 7);
            invoker.ExecuteCommand();
        }
    }
}
