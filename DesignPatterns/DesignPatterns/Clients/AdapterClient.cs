using DesignPatterns.Patterns.Structural.Adapter;
using System;
using System.Collections.Generic;

namespace DesignPatterns.Clients
{
    public class AdapterClient : IClient
    {
        IListFormatter formatter;

        public AdapterClient(IListFormatter formatter)
        {
            this.formatter = formatter;
        }

        public void Execute()
        {
            Console.WriteLine("##############");
            Console.WriteLine("Adapter");
            Console.WriteLine("##############");

            var list = new List<string>
            {
                "a",
                "b",
                "c",
                "d",
            };

            var result = $"Result: { this.formatter.Format(list) }";

            Console.WriteLine(result);
        }
    }
}
