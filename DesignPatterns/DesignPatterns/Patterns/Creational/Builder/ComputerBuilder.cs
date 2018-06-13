namespace DesignPatterns.Patterns.Creational.Builder
{
    public abstract class ComputerBuilder
    {
        protected Computer computer;

        public Computer Computer
        {
            get
            {
                return this.computer;
            }
        }

        public ComputerBuilder()
        {
            this.computer = new Computer();
        }

        public abstract void BuildCpu();

        public abstract void BuildPrimaryMemory();

        public abstract void BuildSecondaryMemory();

        public abstract void BuildGpu();
    }
}
