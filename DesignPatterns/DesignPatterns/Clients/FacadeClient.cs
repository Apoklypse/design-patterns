using DesignPatterns.Patterns.Structural;
using DesignPatterns.Patterns.Structural.Facade;
using DesignPatterns.Utility;
using System.Collections.Generic;

namespace DesignPatterns.Clients
{
    public class FacadeClient : Client
    {
        public FacadeClient()
        {
            this.Name = "Facade";
            this.Category = PatternCategories.Structural;
        }

        protected override void PerfomAction()
        {
            ContactDetail firstContact = new ContactDetail
            {
                Type = ContactNumberTypes.Landline,
                Number = "000 000 0000"
            };

            ContactDetail secondContact = new ContactDetail
            {
                Type = ContactNumberTypes.Cellphone,
                Number = "111 111 1111"
            };

            var contactDetails = new List<ContactDetail>
            {
                firstContact,
                secondContact,
            };

            Person person = new Person
            {
                Name = "John",
                LastName = "Doe",
                ContactDetails = contactDetails,
            };

            var printer = new DetailPrinter() as IDetailPrinter;
            printer.PrintDetail(person);
        }
    }
}