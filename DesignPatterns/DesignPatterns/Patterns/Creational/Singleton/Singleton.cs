using System;
using System.Collections.Generic;
using System.Text;

namespace DesignPatterns.Patterns.Creational.Singleton
{
    public class Singleton
    {
        private static Singleton instance;
        private static object lockSingleton = new object();

        public string Name { get; set; }

        private Singleton() { }

        public static Singleton GetInstance()
        {
            lock(lockSingleton)
            {
                if (instance == null)
                {
                    instance = new Singleton();
                }
            }

            return instance;
        }

    }
}
