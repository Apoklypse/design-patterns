using System;
using System.Collections.Generic;
using System.Text;

namespace DesignPatterns.Patterns.Creational.Builder
{
    public class HighEndComputerBuilder : ComputerBuilder
    {
        public override void BuildCpu()
        {
            this.Computer.Cpu = "High-end CPU";
        }

        public override void BuildGpu()
        {
            this.Computer.Gpu = "High-end GPU";
        }

        public override void BuildPrimaryMemory()
        {
            this.Computer.PrimaryMemory = "High-end RAM";
        }

        public override void BuildSecondaryMemory()
        {
            this.Computer.SecondaryMemory = "High-end HDD";
        }
    }
}
