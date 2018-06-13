using System;
using System.Collections.Generic;
using System.Text;

namespace DesignPatterns.Patterns.Creational.Builder
{
    public class LowEndComputerBuilder : ComputerBuilder
    {
        public override void BuildCpu()
        {
            this.Computer.Cpu = "Low-end CPU";
        }

        public override void BuildGpu()
        {
            this.Computer.Gpu = "Low-end GPU";
        }

        public override void BuildPrimaryMemory()
        {
            this.Computer.PrimaryMemory = "Low-end RAM";
        }

        public override void BuildSecondaryMemory()
        {
            this.Computer.SecondaryMemory = "Low-end HDD";
        }
    }
}
