#include <iostream>
using namespace std;

int main()
{
	int a{}, summ{};

	cout << "Enter a:"; cin >> a;
	while (a <= 500)
	{
		summ += a;
		a++;
	}

	cout << summ;

	return 0;
}


int main()
{
	int x{}, y{};

	cout << "Enter x:";
	cin >> x;
	cout << "Enter y:";
	cin >> y;
	int work = x;
	while (y - 1 > 0)
	{
		y -= 1;
		work *= x;
	}
	cout << work;
	return 0;
}

int main()
{
	float count{}, summ{}, num1 = 1;

	while (num1 <= 1000)
	{
		summ += num1;
		num1++;
		count++;
	}
	float average = summ / count;
	cout << average;

	return 0;
}

int main()
{
	int a{};

	cout << "Enter a:";
	cin >> a;
	int work = a;
	while (a < 20)
	{
		a += 1;
		work *= a;
	}
	cout << work;
	return 0;
}

int main()
{
	int k{}, num1 = 1;

	cout << "Enter k:";
	cin >> k;
	while (num1 <= 10)
	{
		cout << k << " * " << num1 << " = " << k * num1 << endl;
		num1++;
	}
	return 0;
}
