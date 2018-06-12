using DesignPatterns.Patterns.Behavioural.Observer;
using DesignPatterns.Utility;
using System;
using System.Collections.Generic;
using System.Text;

namespace DesignPatterns.Clients
{
    public class ObserverClient : Client
    {
        public ObserverClient()
        {
            this.Name = "Observer";
            this.Category = PatternCategories.Behavioural;
        }

        protected override void PerfomAction()
        {
            var subject = new ListSubject();
            var inOrderObserver = new InOrderListObserver(subject);
            var reverseObserver = new ReverseListObserver(subject);

            subject.Attach(inOrderObserver);
            subject.Attach(reverseObserver);

            subject.addItem("a");
            subject.addItem("b");
            subject.addItem("c");
            subject.addItem("d");
            subject.removeItem("c");
        }
    }
}
