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
                //new StateClient(),
                // new ObserverClient(),

                // Creational
                //new SingletonClient(),
                //new AbstractFactoryClient(),

                // Structural
                //new AdapterClient(new ListFormatter()),
                //new FacadeClient(),
            };

            clients.ForEach(client => client.Execute());

            Console.WriteLine("#End#");
            Console.ReadLine();
        }
    }
}
