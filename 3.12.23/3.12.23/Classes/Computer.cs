using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _3._12._23.Classes
{
    public class Computer
    {
        public string Processor { get; set; }
        public string Memory { get; set; }
        public string GraphicsCard { get; set; }
        public string Storage { get; set; }
        public string AdditionalFeatures { get; set; }

        public void Display()
        {
            Console.WriteLine($"Processor: {Processor}");
            Console.WriteLine($"Memory: {Memory}");
            Console.WriteLine($"Graphics Card: {GraphicsCard}");
            Console.WriteLine($"Storage: {Storage}");
            Console.WriteLine($"Additional Features: {AdditionalFeatures}");
            Console.WriteLine();
        }
    }
}
