using DesignPatterns.Patterns.Creational.Singleton;
using DesignPatterns.Utility;
using System;

namespace DesignPatterns.Clients
{
    public class SingletonClient : Client
    {
        public SingletonClient()
        {
            this.Name = "Singleton (Single lock)";
            this.Category = PatternCategories.Creational;
        }

        protected override void PerfomAction()
        {
            Singleton instance = Singleton.GetInstance();
            instance.Name = "Test";

            Singleton otherInstance = Singleton.GetInstance();

            if (instance.Name.Equals(otherInstance.Name))
            {
                Console.WriteLine("Same instance");
            }
            else
            {
                Console.WriteLine("Different instances");
            }
        }
    }
}