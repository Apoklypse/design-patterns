using System;
using System.Collections.Generic;
using System.Text;

namespace DesignPatterns.Patterns.Behavioural.Observer
{
    public class ListSubject : Subject
    {
        public List<string> List { get; set; }

        public ListSubject()
        {
            this.List = new List<string>();
        }

        public void addItem(string item)
        {
            this.List.Add(item);
            this.Notify();
        }

        public void removeItem(string item)
        {
            this.List.Remove(item);
            this.Notify();
        }
    }
}
