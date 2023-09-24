

#region Task1
/*        Console.Write("Введите число от 1 до 100: ");
        int number;

        if (int.TryParse(Console.ReadLine(), out number))
        {
            if (number >= 1 && number <= 100)
            {
                if (number % 3 == 0 && number % 5 == 0)
                {
                    Console.WriteLine("Fizz Buzz");
                }
                else if (number % 3 == 0)
                {
                    Console.WriteLine("Fizz");
                }
                else if (number % 5 == 0)
                {
                    Console.WriteLine("Buzz");
                }
                else
                {
                    Console.WriteLine(number);
                }
            }
            else
            {
                Console.WriteLine("Ошибка: число не в диапазоне от 1 до 100");
            }
        }
        else
        {
            Console.WriteLine("Ошибка: введите корректное число");
        }*/

#endregion


#region Task2

/*
        Console.Write("Введите значение: ");
        double value;

        if (double.TryParse(Console.ReadLine(), out value))
        {
            Console.Write("Введите процент: ");
            double percent;

            if (double.TryParse(Console.ReadLine(), out percent))
            {
                double result = (value * percent) / 100;
                Console.WriteLine($"{percent}% от {value} = {result}");
            }
            else
            {
                Console.WriteLine("Ошибка: введите корректный процент");
            }
        }
        else
        {
            Console.WriteLine("Ошибка: введите корректное значение");
        }*/



#endregion


#region Task3

/*
        Console.WriteLine("Введите четыре цифры:");

        int[] nums = new int[4];

        for (int i = 0; i < 4; i++)
        {
            Console.Write($"Цифра {i + 1}: ");

            if (int.TryParse(Console.ReadLine(), out nums[i]) && nums[i] >= 0 && nums[i] <= 9)
            {
                continue;
            }
            else
            {
                Console.WriteLine("Ошибка: Введите цифру от 0 до 9.");
                i--; 
            }
        }

        int result = nums[0] * 1000 + nums[1] * 100 + nums[2] * 10 + nums[3];
        Console.WriteLine($"Сформированное число: {result}");

*/


#endregion



#region Task4

/*class Program
{
    static void Main()
    {
        Console.Write("Введите шестизначное число: ");
        string input = Console.ReadLine();

        if (input.Length == 6 && int.TryParse(input, out int number))
        {
            Console.Write("Введите номера разрядов для обмена : ");
            string swapIndicesInput = Console.ReadLine();

            if (TryParseSwapIndices(swapIndicesInput, out int index1, out int index2))
            {
                int swappedNumber = SwapDigits(number, index1, index2);
                Console.WriteLine($"Результат обмена: {swappedNumber}");
            }
            else
            {
                Console.WriteLine("Ошибка: Введите два корректных номера разрядов.");
            }
        }
        else
        {
            Console.WriteLine("Ошибка: Введите корректное шестизначное число.");
        }
    }

    static bool TryParseSwapIndices(string input, out int index1, out int index2)
    {
        index1 = -1;
        index2 = -1;

        string[] indices = input.Split(new char[] { ' ', ',' }, StringSplitOptions.RemoveEmptyEntries);

        if (indices.Length == 2 &&
            int.TryParse(indices[0], out index1) &&
            int.TryParse(indices[1], out index2) &&
            index1 >= 1 && index1 <= 6 &&
            index2 >= 1 && index2 <= 6 &&
            index1 != index2)
        {
            return true;
        }

        return false;
    }

    static int SwapDigits(int number, int index1, int index2)
    {
        int[] digits = new int[6];

        for (int i = 5; i >= 0; i--)
        {
            digits[i] = number % 10;
            number /= 10;
        }

        int temp = digits[index1 - 1];
        digits[index1 - 1] = digits[index2 - 1];
        digits[index2 - 1] = temp;

        int swappedNumber = 0;
        for (int i = 0; i < 6; i++)
        {
            swappedNumber = swappedNumber * 10 + digits[i];
        }

        return swappedNumber;
    }
}*/


#endregion




#region Task5

/*using System;

class Program
{
    static void Main()
    {
        Console.WriteLine("Введите дату (в формате dd.MM.yyyy):");
        string inputDate = Console.ReadLine();

        if (DateTime.TryParseExact(inputDate, "dd.MM.yyyy", null, System.Globalization.DateTimeStyles.None, out DateTime date))
        {

            string season = GetSeason(date.Month);

            string dayOfWeek = date.DayOfWeek.ToString();

            Console.WriteLine($"{season} {dayOfWeek}");
        }
        else
        {
            Console.WriteLine("Некорректный формат даты.");
        }
    }

    static string GetSeason(int month)
    {
        switch (month)
        {
            case 12:
            case 1:
            case 2:
                return "Winter";
            case 3:
            case 4:
            case 5:
                return "Spring";
            case 6:
            case 7:
            case 8:
                return "Summer";
            case 9:
            case 10:
            case 11:
                return "Autumn";
            default:
                return "Unknown Season";
        }
    }
}*/



#endregion




#region Task6
/*
using System;

class Program
{
    static void Main()
    {
        Console.WriteLine("Выберите действие:");
        Console.WriteLine("1. Перевести из Фаренгейта в Цельсий");
        Console.WriteLine("2. Перевести из Цельсия в Фаренгейт");

        int choice;
        if (int.TryParse(Console.ReadLine(), out choice))
        {
            double temperature;
            Console.Write("Введите температуру: ");
            if (double.TryParse(Console.ReadLine(), out temperature))
            {
                double result;
                string fromUnit, toUnit;

                if (choice == 1)
                {
                    result = FahrenheitToCelsius(temperature);
                    fromUnit = "Фаренгейта";
                    toUnit = "Цельсия";
                }
                else if (choice == 2)
                {
                    result = CelsiusToFahrenheit(temperature);
                    fromUnit = "Цельсия";
                    toUnit = "Фаренгейта";
                }
                else
                {
                    Console.WriteLine("Некорректный выбор.");
                    return;
                }

                Console.WriteLine($"Результат: {temperature} {fromUnit} = {result} {toUnit}");
            }
            else
            {
                Console.WriteLine("Некорректная температура.");
            }
        }
        else
        {
            Console.WriteLine("Некорректный выбор.");
        }
    }

 
    static double FahrenheitToCelsius(double fahrenheit)
    {
        return (fahrenheit - 32) * 5 / 9;
    }

    static double CelsiusToFahrenheit(double celsius)
    {
        return celsius * 9 / 5 + 32;
    }
}
*/



#endregion




#region Task7
/*
using System;

class Program
{
    static void Main()
    {
        Console.WriteLine("Введите два числа:");

        int num1, num2;

        if (int.TryParse(Console.ReadLine(), out num1) && int.TryParse(Console.ReadLine(), out num2))
        {
            // Проверка на правильность границ и нормализация
            int start = Math.Min(num1, num2);
            int end = Math.Max(num1, num2);

            Console.WriteLine($"Четные числа в диапазоне от {start} до {end}:");
            for (int i = start; i <= end; i++)
            {
                if (i % 2 == 0)
                {
                    Console.WriteLine(i);
                }
            }
        }
        else
        {
            Console.WriteLine("Некорректный ввод чисел.");
        }
    }
}*/



#endregion



