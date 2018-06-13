using System.Collections.Generic;

namespace DesignPatterns.Patterns.Behavioural.Observer
{
    public class ListSubject : Subject
    {
        public ListSubject()
        {
            this.List = new List<string>();
        }

        public List<string> List { get; set; }

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