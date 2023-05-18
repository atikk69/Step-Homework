#include <iostream>
using namespace std;

int main()
{
	int days1{}, month1{}, year1{}, days2{}, month2{}, year2{}, days{}, tmp{};
	int arr[12]{ 31,28,31,30,31,30,31,31,30,31,30,31 };
	cout << "enter 1 data days:" << endl; cin >> days1;
	cout << "enter 1 data month:" << endl; cin >> month1;
	cout << "enter 1 data year:" << endl; cin >> year1;
	cout << "enter 2 data days:" << endl; cin >> days2;
	cout << "enter 2 data month:" << endl; cin >> month2;
	cout << "enter 2 data year:"; cin >> year2;
	int year = year2 - year1;
	if (year1 > year2)
	{
		tmp = year1;
		year1 = year2;
		year2 = tmp;
	}
	if (month1 > month2)
	{
		tmp = month1;
		month1 = month2;
		month2 = tmp;
	}
	if (days1 > days2)
	{
		tmp = days1;
		days1 = days2;
		days2 = tmp;
	}
	for (size_t i = month2 - 1; i < month1 - 1; i++)
	{
		days += arr[i];
	}
	if (year >= 4)
	{
		while (year > 0)
		{
			year -= 4;
			days += 1;
		}
	}

	if (year1 % 4 == 0 && year2 % 4 != 0 || year2 % 4 == 0 && year1 % 4 != 0)
		days += 1;

	else if (year1 % 4 == 0 && year2 % 4 == 0)
		days += 2;

	days += (year2 - year1) * 365;
	days += days2 - days1;
	cout << "your days raznica is " << days;
}

int average(int* arr,int length)
{
	float summ{};
	for (size_t i = 0; i < length; i++)
	{
		summ += arr[i];
	}
	cout << "average is " << summ / length;
}

void numtips(int* arr, int length)
{
	int positives{}, negatives{}, zeros{};
	for (size_t i = 0; i < length; i++)
	{
		if (arr[i] > 0)
			positives += 1;
		else if (arr[i] == 0)
			zeros += 1;
		else if (arr[i] < 0)
			negatives += 1;
	}
	cout << "positive numbers count is " << positives;
	cout << "0 count is " << zeros;
	cout << "negative numbers count is " << negatives;
}