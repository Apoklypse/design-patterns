using System;
using System.Collections.Generic;

namespace DesignPatterns.Patterns.Behavioural.Observer
{
    public class ReverseListObserver : Observer
    {
        private ListSubject subject;

        public ReverseListObserver(ListSubject subject)
        {
            this.subject = subject;
        }

        public override void Update()
        {
            Console.WriteLine("[Reverse Printer] List has changed:");
            List<String> list = this.subject.List;

            String output = "{ ";
            for (int i = list.Count - 1; i >= 0; i--)
            {
                String item = list[i];
                output += item + (i != 0 ? ", " : " }");
            }

            Console.WriteLine(output);
        }
    }
}