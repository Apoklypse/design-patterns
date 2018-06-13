using DesignPatterns.Patterns.Structural.Adapter;
using DesignPatterns.Utility;
using System;
using System.Collections.Generic;

namespace DesignPatterns.Clients
{
    public class AdapterClient : Client
    {
        private readonly IListFormatter formatter;

        public AdapterClient(IListFormatter formatter)
        {
            this.Name = "Adapter";
            this.Category = PatternCategories.Structural;

            this.formatter = formatter;
        }

        protected override void PerfomAction()
        {
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