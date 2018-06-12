using System;
using System.Collections.Generic;
using System.Text;

namespace DesignPatterns.Patterns.Behavioural.Observer
{
    public abstract class Subject
    {
        private readonly List<Observer> observers = new List<Observer>();

        public void Attach(Observer observer)
        {
            this.observers.Add(observer);
        }

        public void Detach(Observer observer)
        {
            this.observers.Remove(observer);
        }

        public void Notify()
        {
            this.observers.ForEach(observer => observer.Update());
        }
    }
}
