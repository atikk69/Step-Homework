
#include<iostream>
using namespace std;

int main()
{
	int i{},arr[]{ 1, 2, 3, 4, 5, 6, 7, 8, 9, 10 }, arr1[5], arr2[5];
	for (; i < 5; i++)
	{
		arr1[i] = arr[i];
	}
	for (; i < 10; i++)
	{
		arr2[i - 5] = arr[i];
	}
	for (size_t j = 0; j < 5; j++)
	{
		cout << arr1[j] << endl;
	}
	for (size_t j = 0; j < 5; j++)
	{
		cout << arr2[j] << endl;
	}

	return 0;
}


int main()
{
	const int length = 5;
	int i{}, arr1[]{ 1, 2, 3, 4, 5 }, arr2[]{6, 7, 8, 9, 10}, arr[5];
	for (; i < length; i++)
	{
		arr[i] = arr1[i] + arr2[i];
	}
	for (size_t j = 0; j < length; j++)
	{
		cout << arr[j];
	}
	return 0;
}




int main()
{
	char carr[][9]{ "Monday","Tuesday","Wensday","Thursday","Friday","Saturday","Sunday" };
	float arr[7], summ{};
	int count{};
	for (size_t i = 0; i < 7; i++)
	{
		cout << "Enter " << carr[i] << " consumption: ";
		cin >> arr[i];
		if (arr[i] > 100)
			count++;
	}
	for (size_t i = 0; i < 7; i++)
	{
		summ += arr[i];
	}
	float average = summ / 7;
	cout << "Your average consumption is " << average << '$' << endl;
	cout << "Your overall consumption is " << summ << '$' << endl;
	cout << "Count of days when your consuption was bigger than 100$: " << count << endl;
	cout << "Days when your consuption was bigger than 100$:" << endl;
	for (size_t i = 0; i < 7; i++)
	{
		if (arr[i] > 100)
			cout << carr[i] << endl;
	}
	return 0;
}