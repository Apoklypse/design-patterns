using System;
using System.Collections.Generic;

namespace DesignPatterns.Patterns.Behavioural.Observer
{
    public class InOrderListObserver : Observer
    {
        private ListSubject subject;

        public InOrderListObserver(ListSubject subject)
        {
            this.subject = subject;
        }

        public override void Update()
        {
            Console.WriteLine("[In-order Printer] List has changed:");
            List<String> list = this.subject.List;

            String output = "{ ";
            for (int i = 0; i < list.Count; i++)
            {
                String item = list[i];
                output += item + (i != list.Count - 1 ? ", " : " }");
            }

            Console.WriteLine(output);
        }
    }
}