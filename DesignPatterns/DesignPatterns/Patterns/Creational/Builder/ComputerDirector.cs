namespace DesignPatterns.Patterns.Creational.Builder
{
    public class ComputerDirector
    {
        public void MakeComputer(ComputerBuilder builder)
        {
            builder.BuildCpu();
            builder.BuildPrimaryMemory();
            builder.BuildSecondaryMemory();
            builder.BuildGpu();
        }
    }
}