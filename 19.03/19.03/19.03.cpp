#include<iostream>
using namespace std;

void arr3(int* arr1, int* arr2, int len1, int len2)
{
	int count2{}, k{};
	for (size_t i = 0; i < len1; i++)
	{
		int count{};
		for (size_t j = 0; j < len2; j++)
		{
			if (arr1[i] == arr2[j])
				count++;
		}
		if (count == 0)
			count2++;
	}
	int* arr3 = new int[count2] {};
	for (size_t i = 0; i < len1; i++)
	{
		int count{};
		for (size_t b = 0; b < count2; b++)
		{

		}
		for (size_t j = 0; j < len2; j++)
		{
			if (arr1[i] == arr2[j])
				count++;
		}
		if (count == 0)
		{
			arr3[k] = arr1[i];
			k++;
		}
	}
	for (size_t i = 0; i < count2; i++)
	{
		cout << arr3[i] << ' ';
	}

}

void arr3(int* arr1, int* arr2, int len1, int len2)
{
	int count2{}, k{};
	for (size_t i = 0; i < len1; i++)
	{
		int count{};
		for (size_t j = 0; j < len2; j++)
		{
			if (arr1[i] == arr2[j])
				count++;
		}
		if (count == 0)
			count2++;
	}
	for (size_t i = 0; i < len2; i++)
	{
		int count3{};
		for (size_t j = 0; j < len1; j++)
		{
			if (arr2[i] == arr1[j])
				count3++;
		}
		if (count3 == 0)
			count2++;
	}
	int* arr3 = new int[count2] {};
	for (size_t i = 0; i < len1; i++)
	{
		int count{};
		for (size_t j = 0; j < len2; j++)
		{
			if (arr1[i] == arr2[j])
				count++;
		}
		if (count == 0)
		{
			arr3[k] = arr1[i];
			k++;
		}
	}
	for (size_t i = 0; i < len2; i++)
	{
		int count3{};
		for (size_t j = 0; j < len1; j++)
		{
			if (arr2[i] == arr1[j])
				count3++;
		}
		if (count3 == 0)
		{
			arr3[k] = arr2[i];
			k++;
		}
	}
	for (size_t i = 0; i < count2; i++)
	{
		cout << arr3[i] << ' ';
	}

}

int main()
{
	int len1 = 0, len2 = 0;
	cout << "Enter len1: "; cin >> len1;
	cout << "Enter len2: "; cin >> len2;
	int* arr1 = new int[len1] {};
	int* arr2 = new int[len2] {};
	
	for (size_t i = 0; i < len1; i++)
	{
		cout << "Enter " << i + 1 << " num:"; cin >> arr1[i];
	}
	for (size_t i = 0; i < len2; i++)
	{
		cout << "Enter " << i + 1 << " num:"; cin >> arr2[i];
	}
	
	arr3(arr1, arr2, len1, len2);
}