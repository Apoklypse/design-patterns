using DesignPatterns.Clients;
using System;
using System.Collections.Generic;

namespace DesignPatterns
{
    public class Program
    {
        static void Main(string[] args)
        {
            var clients = new List<Client>
            {
                // Behavioural
                //new CommandClient(),
                //new StrategyClient(),

                // Structural
                //new AdapterClient(new ListFormatter()),
                //new FacadeClient(),
            };

            clients.ForEach(client => client.Execute());
            Console.ReadLine();
        }
    }
}
