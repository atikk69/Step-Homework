#include <iostream>
using namespace std;

#pragma region  Task1
int numbers[10]{};

int main()
{
	srand(time(0));

	for (size_t i = 0; i < 10; i++)
	{	
		int num = rand() % 100 + 1;
		numbers[i] = num;
		cout << numbers[i] << " ";
	}

	cout << endl;
	int max = numbers[0];

	for (size_t i = 0; i < 10; i++)
	{
		if (numbers[i] > max)
		{
			max = numbers[i];
		}
	}
	int min = numbers[0];
	for (size_t i = 0; i < 10; i++)
	{
		if (numbers[i] < min)
		{
			min = numbers[i];
		}
	}
	cout << "Max number: " << max << endl;
	cout << "Min number: " << min;
 
  return 0;
}
#pragma endregion

#pragma region Task2
int numbers[10]{};
int start, finish, num{};

int main()
{
	cout << "enter start range: "; cin >> start;
	cout << "enter end range: "; cin >> finish;

	if(finish < start)
	{
		int normalization{};
		normalization = finish;
		finish = start;
		start = normalization;
	}
	cout << "enter number: "; cin >> num;
	srand(time(0));

	for (size_t i = 0; i < 10; i++)
	{
		int num = rand() % (finish - start) + start;
		numbers[i] = num;
		cout << numbers[i] << " ";
	}

	int summ{};

	for (size_t i = 0; i < 10; i++)
	{
		if (numbers[i] < num)
		{
			summ += numbers[i];
		}
	}
	cout << endl << summ;

	return 0;
}
#pragma endregion

#pragma region Task3

int numbers[12]{};
int start, finish{};

int main()
{
	for (size_t i = 0; i < 12; i++)
	{
		cout << "Enter profit of the month " << i + 1 << ':'; cin >> numbers[i];
	}
	
	cout << "Enter start range: " << endl; cin >> start; 
	cout << "Enter end range: " << endl; cin >> finish;
	if(finish < start)
	{
		int normalization{};
		normalization = finish;
		finish = start;
		start = normalization;
	}

	int min = numbers[start];
	int month{};

	for (int i = start - 1; i < finish; i++)
	{
		if (min > numbers[i])
		{
			month = i + 1;
		}
	}
	cout << "Profits were minimal: Month " << month << endl;

	int max = numbers[start];
	month = 0;

	for (int i = start - 1; i < finish; i++)
	{
		if (max < numbers[i])
		{
			month = i + 1;
		}
	}
	cout << "Profits were maximal: Month " << month;

	return 0;
}
#pragma endregion 

#pragma region Task4

int numbers[]{ 3, 6, 12, 73, -6, 24, 84, 171, 72, -4, 56, 103, 53, -15, 12, 1, 4, 31, 41, 68 };
int minn = numbers[0], maxx = numbers[0], imin{}, imax{};
int summinmax = 1, sumeven = 1, sumnegative{}, sumnegativenegative{};
int negative1, negative2{};

int main()
{
	for (size_t i = 0; i < 20; i++)
	{
		if (numbers[i] < 0)
		{
			sumnegative += numbers[i];
		}
	}
	cout << sumnegative << endl;

	for (size_t i = 0; i < 20; i++)
	{
		if (numbers[i] < minn)
		{
			minn = numbers[i];
			imin = i;
		}
		if (numbers[i] > maxx)
		{
			maxx = numbers[i];
			imax = i;
		}
	}

	if (imax < imin)
	{
		int normalization{};
		normalization = imax;
		imax = imin;
		imin = normalization;
	}

	for (size_t i = imin; i < imax; i++)
	{
		summinmax *= numbers[i];
	}
	cout << summinmax << endl;

	for (size_t i = 0; i < 20; i++)
	{
		if (i % 2 == 0)
		{
			sumeven *= numbers[i];
		}
	}
	cout << sumeven << endl;

	for (size_t i = 0; i < 20; i++)
	{
		if (numbers[i] < 0)
		{
			negative1 = i;
			break;
		}
	}

	for (size_t i = 19; i >= 0 ; i--)
	{
		if (numbers[i] < 0)
		{
			negative2 = i;
			break;
		}
	}

	for (size_t i = negative1; i < negative2; i++)
	{
		sumnegativenegative += numbers[i];
	}
	cout << sumnegativenegative;

	return 0;
}