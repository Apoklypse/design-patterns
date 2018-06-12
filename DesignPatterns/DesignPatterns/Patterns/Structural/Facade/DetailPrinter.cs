using System;
using System.Collections.Generic;
using System.Text;

namespace DesignPatterns.Patterns.Structural.Facade
{
    public class DetailPrinter : IDetailPrinter
    {
        private readonly PersonalInformationPrinter piPrinter;
        private readonly ContactInformationPrinter ciPrinter;

        public DetailPrinter()
        {
            this.piPrinter = new PersonalInformationPrinter();
            this.ciPrinter = new ContactInformationPrinter();
        }

        public void PrintDetail(Person person)
        {
            this.piPrinter.PrintPersonalInformation(person);
            this.ciPrinter.PrintContactInformation(person);
        }
    }
}
