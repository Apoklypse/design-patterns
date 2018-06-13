using System.Collections.Generic;

namespace DesignPatterns.Patterns.Structural.Facade
{
    public class Person
    {
        public List<ContactDetail> ContactDetails { get; set; }
        public string LastName { get; set; }
        public string Name { get; set; }
    }
}