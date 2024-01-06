using _3._12._23_2.Interfaces;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _3._12._23_2.Classes
{
    public class Truck : IAutomobile
    {
        public void GetInfo()
        {
            Console.WriteLine("Truck: Designed for heavy-duty hauling and towing.");
        }
    }
}
