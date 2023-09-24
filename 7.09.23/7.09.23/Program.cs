using System.Data;
using System.Runtime.CompilerServices;
using System.Threading.Channels;


#region Part1

/*Console.WriteLine("1. Из десятичной в двоичную");
Console.WriteLine("2. Из десятичной в троичную");

Console.Write("Enter your choice: ");
int choice = int.Parse(Console.ReadLine());

Console.Write("Enter your number: ");
int number = int.Parse(Console.ReadLine());

List<int> list = new List<int>();

switch (choice)
{
    case 1:
    {
        while (number != 0)
        {
            list.Add(number % 2);
            number /= 2;
        }

        list.Reverse();
        for (int i = 0; i < list.Count; i++)
        {
            Console.Write(list[i]);
        }
        break;
    }

}*/

#endregion

#region Part2


/*
Console.Write("Enter number 0 - 9 word: ");
string word = Console.ReadLine();

int[] number = new[]{0,1,2,3,4,5,6,7,8,9};

switch (word)
{
    case "zero":
    {
        Console.WriteLine(number[0]);
        break;
    }
    case "one":
    {
        Console.WriteLine(number[1]);
        
        break;
    }
    case "two":
    {
        Console.WriteLine(number[2]);
        
        break;
    }
    case "three":
    {
        Console.WriteLine(number[3]);
        
        break;
    }
    case "four":
    {
        Console.WriteLine(number[4]);
        
        break;
    }
    case "five":
    {
        Console.WriteLine(number[5]);
        
        break;
    }
    case "six":
    {
        Console.WriteLine(number[6]);
        
        break;
    }
    case "sever":
    {
        Console.WriteLine(number[7]);
        
        break;
    }
    case "eight":
    {
        Console.WriteLine(number[8]);
        
        break;
    }
    case "nine":
    {
        Console.WriteLine(number[9]);
        
        break;
    }
    
}
*/





#endregion

#region Part3




/*
try
{
    string pasNum = "1212122346";
    string fullName = "Ziya Hacili";
    DateTime issueDate = new DateTime(2020, 7, 21);
    Passport passport = new Passport(pasNum,fullName, issueDate);

    Console.WriteLine(passport);
    
}
catch (Exception ex)
{
    Console.WriteLine(ex.Message);
}

public class Passport
{       
    private string passportNumber;
    private string fullName;
    private DateTime issueDate;


    public string PassportNumber
    {
        get => passportNumber;
        set
        {
            if (value.Length > 10 )
                throw new Exception("The passport number consists of only 10 digits.");
            passportNumber = value;
        }
    }

    public string FullName
    {
        get => fullName;
        set
        {
            if (string.IsNullOrEmpty(value) || string.IsNullOrWhiteSpace(value))
                throw new Exception("Error! FullName");
            fullName = value;
        }
    }

    public DateTime IssueDate
    {
        get => issueDate;
        set
        {
            if (value > DateTime.Now)
                throw new Exception("Error Date");
            issueDate = value;
        }
    }
    
    public Passport(string passportNumber, string fullName, DateTime issueDate)
    {
        PassportNumber = passportNumber;
        FullName = fullName;
        IssueDate = issueDate;

        
    }

    public override string ToString()
    {
        return $"Full name: {FullName}\n" +
               $"Passport number: {PassportNumber}\n" +
               $"Issue date: {IssueDate}\n";
    }

  
}
*/




#endregion