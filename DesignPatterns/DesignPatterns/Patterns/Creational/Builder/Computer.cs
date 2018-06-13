namespace DesignPatterns.Patterns.Creational.Builder
{
    public class Computer
    {
        public string Cpu { get; set; }

        public string Gpu { get; set; }
        public string PrimaryMemory { get; set; }

        public string SecondaryMemory { get; set; }

        public override string ToString()
        {
            return
                $"Cpu: { this.Cpu }\n" +
                $"Primary Memory: { this.PrimaryMemory }\n" +
                $"Secondary Memory: { this.SecondaryMemory }\n" +
                $"Gpu: { this.Gpu }\n";
        }
    }
}