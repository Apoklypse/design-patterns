using System;

namespace DesignPatterns.Patterns.Structural.Facade
{
    public class PersonalInformationPrinter
    {
        public void PrintPersonalInformation(Person person)
        {
            String result = "Personal Information\n";

            result += $"Name: { person.Name }\n";
            result += $"Surname: { person.LastName }\n";

            Console.WriteLine(result);
        }
    }
}