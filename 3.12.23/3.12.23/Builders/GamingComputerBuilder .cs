using _3._12._23.Classes;
using _3._12._23.Interfaces;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _3._12._23.Builders;
public class GamingComputerBuilder : IComputerBuilder
{
    private Computer computer = new Computer();

    public void BuildProcessor()
    {
        computer.Processor = "AMD Ryzen 7";
    }

    public void BuildMemory()
    {
        computer.Memory = "16GB DDR4";
    }

    public void BuildGraphicsCard()
    {
        computer.GraphicsCard = "NVIDIA GeForce RTX 3080";
    }

    public void BuildStorage()
    {
        computer.Storage = "1TB NVMe SSD";
    }

    public void BuildAdditionalFeatures()
    {
        computer.AdditionalFeatures = "RGB Lighting, Gaming Keyboard, Gaming Mouse";
    }

    public Computer GetComputer()
    {
        return computer;
    }
}

