using DesignPatterns.Patterns.Creational.Builder;
using DesignPatterns.Utility;
using System;
using System.Collections.Generic;
using System.Text;

namespace DesignPatterns.Clients
{
    public class BuilderClient : Client
    {
        public BuilderClient()
        {
            this.Name = "Builder";
            this.Category = PatternCategories.Creational;
        }

        protected override void PerfomAction()
        {
            var builder = new HighEndComputerBuilder();
            var director = new ComputerDirector();

            director.MakeComputer(builder);

            var computer = builder.Computer;
            Console.WriteLine(computer);
        }
    }
}
