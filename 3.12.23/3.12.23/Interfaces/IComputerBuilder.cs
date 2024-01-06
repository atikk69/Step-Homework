using _3._12._23.Classes;
using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _3._12._23.Interfaces
{
    public interface IComputerBuilder
    {
        void BuildProcessor();
        void BuildMemory();
        void BuildGraphicsCard();
        void BuildStorage();
        void BuildAdditionalFeatures();
        Computer GetComputer();
    }

}
