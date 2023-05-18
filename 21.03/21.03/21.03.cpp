#include <iostream>
#include <string.h>
using namespace std;


void Igor(char** arr1, int* arr2, int len)
{
	int min = arr2[0], max = arr2[0];
	for (size_t i = 0; i < len; i++)
	{
		if (arr2[i] > max)
			max = arr2[i];

		else if (arr2[i] < min)
			min = arr2[i];
	}

	char** arr3 = new char* [len] {};
	int* arr4 = new int [len] {};
	int* arr5 = new int [len] {};
	for (size_t i = 0; i < len; i++)
	{
		arr3[i] = arr1[i];
	}
	for (size_t i = 0; i < len; i++)
	{
		arr5[i] = arr2[i];
	}

	for (size_t i = 0; i < len; i++)
	{
		int index{};
		for (size_t j = 0; j < len; j++)
		{
			if (i == j)
				continue;
			int k{};
			while (int(arr1[i][k]) == int(arr1[j][k]))
			{
				k++;
			}
			if (int(arr1[i][k]) > int(arr1[j][k]))
				index++;
		}
		arr4[i] = index;
	}


	for (size_t i = 0; i < len; i++)
	{
		arr1[arr4[i]] = arr3[i];
		arr2[arr4[i]] = arr5[i];
	}
	for (size_t i = 0; i < len; i++)
	{
		cout << arr1[i] << ' ' << arr2[i] << endl;

	}
	cout << "Minimmum is " << min;
	cout << "Maximumm is " << max;

}

int main()
{
	int len{};
	cout << "Enter length: "; cin >> len;
	char** arr1 = new char* [len] {};
	int* arr2 = new int[len] {};
	for (size_t i = 0; i < len; i++)
	{
		arr1[i] = new char[10];
	}
	for (size_t i = 0; i < len; i++)
	{
		cout << "Enter " << i + 1 << " slovo "; cin >> arr1[i];
	}
	for (size_t i = 0; i < len; i++)
	{
		cout << "Enter " << i + 1 << " good's cost: "; cin >> arr2[i];
	}
	Igor(arr1, arr2, len);
}
