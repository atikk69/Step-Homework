using _3._12._23_2.Factories;
using _3._12._23_2.Interfaces;

class Program
{
    static void Main()
    {
        IAutomobileFactory sedanFactory = new SedanFactory();
        IAutomobileFactory suvFactory = new SUVFactory();
        IAutomobileFactory truckFactory = new TruckFactory();

        IAutomobile sedan = sedanFactory.CreateAutomobile();
        IAutomobile suv = suvFactory.CreateAutomobile();
        IAutomobile truck = truckFactory.CreateAutomobile();

        Console.WriteLine("Information about automobiles:");
        Console.WriteLine("--------------------------------");
        sedan.GetInfo();
        suv.GetInfo();
        truck.GetInfo();
    }
}