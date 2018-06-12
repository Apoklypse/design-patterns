using System;

namespace DesignPatterns.Clients
{
    public abstract class Client
    {
        public string Name { get; set; }

        public string Category { get; set; }

        public void Execute()
        {
            Console.WriteLine("############################");
            Console.WriteLine($"{Name} ({Category})");
            Console.WriteLine("############################");

            PerfomAction();

            Console.WriteLine();
        }

        protected abstract void PerfomAction();
    }
}
