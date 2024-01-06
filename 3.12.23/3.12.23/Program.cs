

using _3._12._23.Builders;
using _3._12._23.Classes;
using _3._12._23.Directors;
using _3._12._23.Interfaces;

class Program
{
    static void Main()
    {
        ComputerDirector director = new ComputerDirector();

        IComputerBuilder officeComputerBuilder = new OfficeComputerBuilder();
        director.ConstructComputer(officeComputerBuilder);
        Computer officeComputer = officeComputerBuilder.GetComputer();
        Console.WriteLine("Office Computer:");
        officeComputer.Display();


        IComputerBuilder gamingComputerBuilder = new GamingComputerBuilder();
        director.ConstructComputer(gamingComputerBuilder);
        Computer gamingComputer = gamingComputerBuilder.GetComputer();
        Console.WriteLine("Gaming Computer:");
        gamingComputer.Display();


        IComputerBuilder designerComputerBuilder = new DesignerComputerBuilder();
        director.ConstructComputer(designerComputerBuilder);
        Computer designerComputer = designerComputerBuilder.GetComputer();
        Console.WriteLine("Designer Computer:");
        designerComputer.Display();
    }
}