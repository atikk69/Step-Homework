#include <iostream>
using namespace std;

int main()
{
	const int length1 = 2,length2 = 5;
	float arr[length1][length2]{ {1,2,3,4,5},{6,7,8,9,10} }, summ{}, count{},min = arr[0][0], max = arr[0][0];
	for (size_t i = 0; i < length1; i++)
	{
		for (size_t j = 0; j < length2; j++)
		{
			summ += arr[i][j];
			count++;
		}
		for (size_t j = 0; j < length2; j++)
		{
			if (arr[i][j] < min)
				min = arr[i][j];
		}
		for (size_t j = 0; j < length2; j++)
		{
			if (arr[i][j] > max)
				max = arr[i][j];
		}
	}
	float average = summ / count;
	cout << "Summ is " << summ << endl;
	cout << "Average is " << average << endl;
	cout << "Max is " << max << endl;
	cout << "Min is " << min << endl;
}



int main()
{
	int arr1[5][10]{ { 1,2,3,4,5,6,7,8,9,10 },{11,12,13,14,15,16,17,18,19,20}, {21,22,23,24,25,26,27,28,29,30},{31,32,33,34,35,36,37,38,39,40},{41,42,43,44,45,46,47,48,49,50} };
	int arr2[5][5]{}, length1 = 5;
	for (size_t i = 0; i < length1; i++)
	{
		for (size_t j = 1; j <= length1; j++)
		{
			arr2[i][j - 1] = arr1[i][(j * 2) - 2] + arr1[i][(j * 2) - 1];
		}
	}
	for (size_t i = 0; i < length1; i++)
	{
		for (size_t j = 0; j < length1; j++)
		{
			cout << arr2[i][j] << endl;
		}
	}
}



int main()
{
	const int length1 = 4, length2 = 5;
	int arr[4][5]{
		{3,5,6,7,0},
		{12,1,1,1,0},
		{0,7,12,1,0},
		{0,0,0,0,0}};
	for (size_t i = 0; i < length1; i++)
	{
		for (size_t j = 0; j < length2 - 1; j++)
		{
			arr[i][length2 - 1] += arr[i][j];
		}
	}
	for (size_t i = 0; i < length1 + 1; i++)
	{
		for (size_t j = 0; j < length2 - 2; j++)
		{
			arr[length1 - 1][i] += arr[j][i];
		}
	}
	for (size_t i = 0; i < length1;i++)
	{
		for (size_t j = 0; j < length2; j++)
		{
			cout << arr[i][j] << ' ';
		}
		cout << endl;
	}
}