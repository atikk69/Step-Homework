using _3._12._23.Interfaces;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _3._12._23.Directors;
public class ComputerDirector
{
    public void ConstructComputer(IComputerBuilder builder)
    {
        builder.BuildProcessor();
        builder.BuildMemory();
        builder.BuildGraphicsCard();
        builder.BuildStorage();
        builder.BuildAdditionalFeatures();
    }
}

