using System;
using System.Collections.Generic;
using System.Text;

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
