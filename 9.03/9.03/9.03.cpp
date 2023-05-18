
#include <iostream>
using namespace std;


void degree(int num,int degree)
{
	int num1 = num;
	while (degree > 1)
	{
		degree--;
		num *= num1;
	}
	cout << num;
}

void summInRange(int num1, int num2)
{
	int num = num1,count = num2 - num1;
	while (count > 0)
	{
		num1++;
		num += num1;
		count--;
	}
	cout << num;
}

void perfectNum(int start, int end)
{
	while (start < end)
	{
		int num{}, num2{};
		while (num + 1 < start)
		{
			num++;
			if (start % num == 0)
				num2 += num;
		}
		if (num2 == start)
			cout << num2 << ' ';
		start++;
	}
}


void luckyNum(int num)
{
	int num1 = num % 10, num2 = (num % 100) / 10, num3 = (num % 1000) / 100, num4 = (num % 10000) / 1000, num5 = (num % 100000) / 10000, num6 = num / 100000;
	if (num1 + num2 + num3 == num4 + num5 + num6)
		cout << "It's lucky number";
	else
		cout << "It'snt lucky number";
}

