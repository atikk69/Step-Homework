using Microsoft.VisualBasic;
using System;
using System.Data;
using System.Diagnostics.CodeAnalysis;
using System.Globalization;
using System.Linq.Expressions;
using System.Runtime.CompilerServices;
using System.Security.Cryptography.X509Certificates;

#region Task1

/*int[] arr = new int[5];
Console.WriteLine("Enter first array: ");


for (int i = 0; i < arr.Length; i++)
{
    arr[i] = Int32.Parse(Console.ReadLine());
}


Random random = new Random();
int[,] multiArr = new int[3,4];

for (int i = 0;i < 3; i++)
{
	for (int j = 0; j < 4; j++)
	{
		multiArr[i,j] = random.Next(1,11);
	}
}

Console.WriteLine("Array numbers");
for (int i = 0; i < arr.Length ; i++)
{
	Console.Write(arr[i] + " ");
}

Console.WriteLine();

Console.WriteLine("Multi array numbers");
for (int i = 0; i < 3; i++)
{
	for (int j = 0; j < 4; j++)
	{
		Console.Write(multiArr[i,j] + "\t");
	}
	Console.WriteLine();
}

int minNum = multiArr[0, 0];
int maxNum = multiArr[0, 0];

for (int i = 0; i < 3; i++)
{
	for(int j = 0;j < 4; j++)
	{
		if (multiArr[i,j] < minNum)
		{
			minNum = multiArr[i,j];
		}
		if (multiArr[i,j] > maxNum)
		{
			maxNum = multiArr[i, j];
		}
	}
}

if (minNum == arr.Min())
	Console.WriteLine($"Min number: {minNum}");
else
	Console.WriteLine("Not having min number in arr and multi array");

if (maxNum == arr.Max())
	Console.WriteLine($"Max number {maxNum}");
else
	Console.WriteLine("Not having max number in arr and multi arr");



int avgSum = 0;
for (int i = 0; i < arr.Length; i++)
{
	avgSum += arr[i];
}
for(int i = 0;i < 3;i++)
{
	for (int j = 0; j < 4; j++)
	{
		avgSum += multiArr[i, j];
	}
}
Console.WriteLine($"Average sum: {avgSum}");


double avgMult = 1;
for (int i = 0; i < arr.Length; i++)
{
    avgMult *= arr[i];
}
for (int i = 0; i < 3; i++)
{
    for (int j = 0; j < 4; j++)
    {
        avgMult *= multiArr[i, j];
    }
}

Console.WriteLine($"Average multiplication: {avgMult}");

Int64 evenNumbSum = 0;

for (int i = 0; i < arr.Length; i++)
{
	if (arr[i] % 2 == 0)
        evenNumbSum += arr[i];
}

Console.WriteLine($"Even numbers sum: {evenNumbSum}");

int oddNumSum = 0;

for(int i = 0; i < 3; i++)
{
	for(int j = 0;j < 4; j++)
	{
		if (multiArr[i, j] % 2 != 0)
			oddNumSum += multiArr[i, j];
    }
}

Console.WriteLine($"Odd numbers sum: {oddNumSum}");
*/

#endregion

#region Task2
/*int[,] arr = new int[5, 5];
Random random = new Random();
int minNum = 0;
int maxNum = 0;



for (int i = 0; i < 5; i++)
{
	for (int j = 0; j < 5; j++)
	{
		arr[i,j] = random.Next(-100,101);
	}
}

//Min num

for (int i = 0;i < 5; i++)
{
	for(int j = 0;j < 5; j++)
	{
		if (minNum > arr[i,j])
		{
			minNum = arr[i, j];
		}
	}
}

//Max num

for (int i = 0; i < 5; i++)
{
	for (int j = 0; j < 5; j++)
	{
		if (maxNum < arr[i,j])
		{
			maxNum = arr[i, j];
		}
	}
}

int sumMinMax = minNum + maxNum;
Console.WriteLine($"Sum between min and max : {sumMinMax}");*/
#endregion

#region Task3

/*
string str = Console.ReadLine();
int[] intStr = new int[str.Length];


//шифровка
for (int i = 0; i < str.Length; i++)
{
    char elem = str[i];
    intStr[i] = elem;

}

for (int i = 0; i < intStr.Length; i++)
{
    intStr[i] += 3;
}


string newString = "";

for (int i = 0; i < intStr.Length; i++)
{
	newString += (char)intStr[i];
}


//расшифровка
int[] decipher = new int[newString.Length];
for (int i = 0; i < newString.Length; i++)
{
	char elem = newString[i];
	decipher[i] = elem;
}


string decipherStr = "";
for (int i = 0; i < decipher.Length; i++)
{
	decipher[i] -= 3;
}


for (int i = 0; i < decipher.Length; i++)
{
	decipherStr += (char)decipher[i];
}
*/
#endregion

#region Task4


// умножение
/*
int[,] matrix = new int[2, 2];
int[,] matrix2 = new int[2, 2];

int[,] matrix3 = new int[2, 2];

Random random = new Random();

for (int i = 0; i < 2; i++)
{
	for (int j = 0; j < 2; j++)
	{
		matrix[i, j] = random.Next(1,10);
	}
}

for (int i = 0;i < 2; i++)
{
	for(int j = 0;j < 2; j++)
	{
		matrix2[i,j] = random.Next(1,10);
	}
}

for (int i = 0; i < 2; i++)
{
	for (int j = 0; j < 2; j++)
	{
		int sum = 0;
		for (int k = 0; k < 2; k++)
		{
			sum += matrix[i, k] * matrix2[k, j];
		}
		matrix3[i, j] = sum;
	}
}

for (int i = 0; i < 2; i++)
{
	for (int j = 0; j < 2; j++)
	{
		Console.Write(matrix3[i,j] + "\t");
	}
}*/


//sum
/*int[,] matrix = new int[2, 2];
int[,] matrix2 = new int[2, 2];

int[,] matrix3 = new int[2, 2];

Random random = new Random();

for (int i = 0; i < 2; i++)
{
    for (int j = 0; j < 2; j++)
    {
        matrix[i, j] = random.Next(1, 10);
    }
}

for (int i = 0; i < 2; i++)
{
    for (int j = 0; j < 2; j++)
    {
        matrix2[i, j] = random.Next(1, 10);
    }
}

for (int i = 0; i < 2; i++)
{
	for (int j = 0; j < 2; j++)
	{
		int sum = 0;
		for (int k = 0; k < 2; k++)
		{
			sum += matrix[i, k] + matrix2[k, j];
		}
		matrix3[i, j] = sum;
	}
}

for (int i = 0; i < 2; i++)
{
	for (int j = 0; j < 2; j++)
	{
		Console.Write(matrix3[i,j] + "\t");

    }
}*/

#endregion

#region Task6


/*string text = Console.ReadLine();

TextInfo ti = CultureInfo.CurrentCulture.TextInfo;

Console.WriteLine(ti.ToTitleCase(text));*/


#endregion

#region Task7

/*string text = Console.ReadLine();
string word = Console.ReadLine();

for (int i = 0; i < text.Length ; i++)
{
	text = text.Replace(word, "");
}



Console.WriteLine(text);*/


#endregion