using _3._12._23.Classes;
using _3._12._23.Interfaces;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _3._12._23.Builders
{
    public class OfficeComputerBuilder : IComputerBuilder
    {
        private Computer computer = new Computer();

        public void BuildProcessor()
        {
            computer.Processor = "Intel Core i5";
        }

        public void BuildMemory()
        {
            computer.Memory = "8GB DDR4";
        }

        public void BuildGraphicsCard()
        {
            computer.GraphicsCard = "Integrated Graphics";
        }

        public void BuildStorage()
        {
            computer.Storage = "256GB SSD";
        }

        public void BuildAdditionalFeatures()
        {
            computer.AdditionalFeatures = "Office Suite";
        }

        public Computer GetComputer()
        {
            return computer;
        }
    }

}
