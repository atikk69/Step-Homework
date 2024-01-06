using _3._12._23_2.Classes;
using _3._12._23_2.Interfaces;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _3._12._23_2.Factories
{
    public class TruckFactory : IAutomobileFactory
    {
        public IAutomobile CreateAutomobile()
        {
            return new Truck();
        }
    }

}
