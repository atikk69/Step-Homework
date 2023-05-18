#include <iostream>
using namespace std;

#pragma region Task1
int matrix(int numbers[5][5])
{
	srand(time(0));

	for (size_t i = 0; i < 5; i++)
	{
		for (size_t j = 0; j < 5; j++)
		{
			numbers[i][j] = rand() % 10 + 1;
		}
	};

	return 0;
}

int matrix(int numbers[5][5], int i)
{
	for (size_t i = 0; i < 5; i++)
	{
		for (size_t j = 0; j < 5; j++)
		{
			cout << numbers[i][j] << ' ';
		}
	}

	return 0;
}

int matrix(int numbers[5][5], int& minimum, int& maximum)
{
	minimum = numbers[0][0], maximum = numbers[0][0];

	for (int i = 0; i < 5; i++)
	{
		if (minimum > numbers[i][i])
			minimum = numbers[i][i];
		if (maximum < numbers[i][i])
			maximum = numbers[i][i];
	}
	return 0;
}

int matrix(int numbers[5][5], float sort)
{
	for (size_t i = 0; i < 5; i++)
	{
		for (size_t b = 0; b < 5; b++)
		{
			for (size_t j = 0; j < 5; j++)
			{
				if (numbers[i][b] < numbers[i][j])
				{
					int a{};
					a = numbers[i][b];
					numbers[i][b] = numbers[i][j];
					numbers[i][j] = a;
				}
			}
		}
	}

	return 0;
}

int main()
{
	int min{}, max{};
	int arr[5][5]{};


	matrix(arr);
	matrix(arr, 0);
      matrix(arr, min, max);
	matrix(arr, 0);

	return 0;
}
#pragma endregion

#pragma region Task2
int gsd(int num1, int num2, int i)
{
	static int divider{}, stop{};

	if (num1 > num2)
	{
		stop = num2;
	}
	else
	{
		stop = num1;
	}

	if (num1 % i == 0 && num2 % i == 0)
	{
		divider = i;
	}

	if (i == stop)
	{
		return divider;
	}

	gsd(num1, num2, i + 1);
}

int main()
{
	int number1{}, number2{}, i = 1;

	cout << "Enter number 1: "; cin >> number1;
	cout << "Enter number 2: "; cin >> number2;

	int res = gsd(number1, number2, i);

	cout << res;

	return 0;
}
#pragma endregion 

#pragma region Task3
void bullscows(int bulls[], int cows[], int i)
{
	static int numbers{}, count{};

	if (bulls[i] == cows[i])
	{
		numbers++;
	}

	if (i == 3)
	{
		if (numbers == 4)
		{
			count++;
			cout << "You guessed right in " << count <<  " attempts!";
		}
		else
		{
			cout << "You gussed number: " << numbers << endl;
			cout << "Please re-enter: ";
			for (size_t i = 0; i < 4; i++)
			{
				cout << "Enter number " << i + 1 << ':'; cin >> cows[i];
			}
			count++;
			i = -1;
			numbers = 0;
		}
	}

	bullscows(bulls, cows, i + 1);
}

int main()
{
	int bulls[4]{}, cows[4]{};

	srand(time(NULL));
	for (size_t i = 0; i < 4; i++)
	{
		bulls[i] = rand() % 10 + 1;
	}

	for (size_t i = 0; i < 4; i++)
	{
		cout << "Enter number " << i + 1 << ':'; cin >> cows[i];
	}

	bullscows(bulls, cows, 0);

	return 0;
}
#pragma endregion
