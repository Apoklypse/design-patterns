using System.Collections.Generic;

namespace DesignPatterns.Patterns.Structural.Facade
{
    public class Person
    {
        public string Name { get; set; }

        public string LastName { get; set; }

        public List<ContactDetail> ContactDetails { get; set; }
    }
}
