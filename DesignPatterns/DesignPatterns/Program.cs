using DesignPatterns.Clients;
using DesignPatterns.Patterns.Structural.Adapter;
using System;
using System.Collections.Generic;

namespace DesignPatterns
{
    public class Program
    {
        static void Main(string[] args)
        {
            var clients = new List<IClient>
            {
                new AdapterClient(new ListFormatter()),
            };

            clients.ForEach(client => client.Execute());
            Console.ReadLine();
        }
    }
}
