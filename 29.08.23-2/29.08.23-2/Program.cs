using System;
using System.Data;
using System.Globalization;


#region Module1

#region Task1
/*Console.Write("Enter number number 1 - 100: ");
int num1 = Int32.Parse(Console.ReadLine());


if (num1 < 0 || num1 > 100)
    Console.WriteLine("Error");
else if (num1 % 3 == 0 && num1 % 5 == 0)
    Console.WriteLine("Fizz Buzz");
else if (num1 % 3 != 0 && num1 % 5 != 0)
    Console.WriteLine(num1);
else if (num1 % 3 == 0)
    Console.WriteLine("Fizz");
else if (num1 % 5 == 0)
    Console.WriteLine("Buzz");*/
#endregion

#region Taskt2

/*Console.Write("Enter value: ");
double num = Int32.Parse(Console.ReadLine());

Console.Write("Enter percent: ");
double percent = Int32.Parse(Console.ReadLine());

Console.WriteLine(num / 100 * percent);*/



#endregion

#region Taskt3
/*
Console.Write("Enter first number: ");
int num1 = Int32.Parse(Console.ReadLine());

Console.Write("Enter second number: ");
int num2 = Int32.Parse(Console.ReadLine());

Console.Write("Enter third number: ");
int num3 = Int32.Parse(Console.ReadLine());

Console.Write("Enter forth number: ");
int num4 = Int32.Parse(Console.ReadLine());

Console.Write(num1);
Console.Write(num2);
Console.Write(num3);
Console.Write(num4);
*/


#endregion

#region Task4
/*
Console.Write("Enter 6 digit number: ");
int number = Int32.Parse(Console.ReadLine());

int examNum = number;
int examNum2 = number;
int finExamNum3 = number;

int i = 0;

while (examNum != 0)
{
    examNum /= 10;
    i++;
}

if (i != 6)
    Console.WriteLine("Error");
else if (i == 6)
{
    List<int> list = new List<int>();

    Console.Write("Enter first number for exchange: ");
    int num1 = Int32.Parse(Console.ReadLine());

    Console.Write("Enter second number for exchange: ");
    int num2 = Int32.Parse(Console.ReadLine());

    int num = 100000;
    int firstDeg = 0;
    int secondDeg = 0;

    for (int j = 0; j < i; j++)
    {
        
        int examNum3 = examNum2 / num;
        list.Add(examNum3);
        examNum2 %= num;
        num /= 10;

        if ((j+1) == num1)
            firstDeg = examNum3;
        if ((j+1) == num2)
            secondDeg = examNum3;
      
    }

  

    list[num1-1] = secondDeg;
    list[num2 - 1] = firstDeg;

    for (int j = 0; j < i; j++)
    {
        Console.Write(list[j]);
    }



}

*/



#endregion

#region Task5



/*DateTime Data()
{
    DateTime data;
    string input;

    do
    {
        Console.WriteLine("Enter data: ");
        input = Console.ReadLine();
    } while (!DateTime.TryParseExact(input, "dd.MM.yyyy",null, DateTimeStyles.None, out data));

    return data;
        
}

var data = Data();

Console.WriteLine(data.DayOfWeek);
Console.WriteLine(data.Month);*/

#endregion

#region Task6

/*Console.WriteLine("1. Цельсий - Фаренгейт");
Console.WriteLine("2. Фаренгейт - Цельсий");

Console.Write("Enter your choice: ");
int choice = Int32.Parse(Console.ReadLine());



switch (choice)
{
    case 1:
        {
            Console.WriteLine("Введи градусы в Цельсий: ");
            double tempCelsiy = Double.Parse(Console.ReadLine());

            double tempFarengeyt = tempCelsiy * 1.8 + 32;

            Console.WriteLine(tempFarengeyt);



            break;
        }
    case 2:
        {

            Console.WriteLine("Введи градусы в Фаренгейтах: ");
            double tempFarengeyt = Double.Parse(Console.ReadLine());

            double tempCelsiy = (tempFarengeyt - 32) / 1.8;

            Console.WriteLine(tempCelsiy);

            break;
        }
    default:
        Console.WriteLine("Error");
        break;
}*/


#endregion

#region Task7

/*
Console.Write("Enter start: ");
int start = Int32.Parse(Console.ReadLine());

Console.Write("Enter end: ");
int end = Int32.Parse(Console.ReadLine());

if (start > end) // 20 > 11 
{
    for (int i = end*//*20*//*; i < start *//*11*//*; i++)
    {
        if (i % 2 == 0)
            Console.WriteLine(i);
    }
}
else if (end > start)
{
    for (int i = start; i < end; i++)
    {
        if (i % 2 == 0)
            Console.WriteLine(i);
    }

}
else if (start == end)
    Console.WriteLine("Error!");*/


#endregion

#endregion

