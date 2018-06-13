namespace DesignPatterns.Patterns.Creational.Builder
{
    public abstract class ComputerBuilder
    {
        protected Computer computer;

        public ComputerBuilder()
        {
            this.computer = new Computer();
        }

        public Computer Computer
        {
            get
            {
                return this.computer;
            }
        }

        public abstract void BuildCpu();

        public abstract void BuildGpu();

        public abstract void BuildPrimaryMemory();

        public abstract void BuildSecondaryMemory();
    }
}