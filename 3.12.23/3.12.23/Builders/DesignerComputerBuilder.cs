using _3._12._23.Classes;
using _3._12._23.Interfaces;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _3._12._23.Builders;

public class DesignerComputerBuilder : IComputerBuilder
{
    private Computer computer = new Computer();

    public void BuildProcessor()
    {
        computer.Processor = "Intel Core i7";
    }

    public void BuildMemory()
    {
        computer.Memory = "32GB DDR4";
    }

    public void BuildGraphicsCard()
    {
        computer.GraphicsCard = "NVIDIA Quadro P5000";
    }

    public void BuildStorage()
    {
        computer.Storage = "2TB HDD, 512GB SSD";
    }

    public void BuildAdditionalFeatures()
    {
        computer.AdditionalFeatures = "4K Display, Graphics Tablet";
    }

    public Computer GetComputer()
    {
        return computer;
    }
}