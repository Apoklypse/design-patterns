namespace DesignPatterns.Patterns.Structural.Facade
{
    public class DetailPrinter : IDetailPrinter
    {
        private readonly ContactInformationPrinter ciPrinter;
        private readonly PersonalInformationPrinter piPrinter;

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