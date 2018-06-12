using System;
using System.Collections.Generic;
using System.Text;

namespace DesignPatterns.Patterns.Structural.Facade
{
    public class ContactInformationPrinter
    {
        public void PrintContactInformation(Person person)
        {
            person.ContactDetails.ForEach(contactDetail =>
            {
                String result = "Contact Details\n";

                result += $"Type: { contactDetail.Type.ToString() }\n";
                result += $"Number: { contactDetail.Number }\n";

                Console.WriteLine(result);
            });
        }
    }
}
