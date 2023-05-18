#include <iostream>
using namespace std;

int main()
{
	int a = 100, b = 999, count{};

	while (a < b)
	{
		if ((a / 100) == ((a % 100) / 10) || (a % 10) == ((a % 100) / 10) || (a % 10) == (a / 100))
		{
			count++;
			a++;
		}
		else
		{
			a++;
		}
	}

	cout << count;
 
	return 0;
}


int main()
{
	
	
	int a = 100, b = 999, count{};
	
	while (a < b)
	{
		if ((a / 100) != ((a % 100) / 10) && (a % 10) != ((a % 100) / 10) && (a % 10) != (a / 100))
		{
			count++;
			a++;
		}
		else
		{
			a++;
		}
	}
	
		cout << count;
	
	return 0;
}

int main()
{
	int num{}, division = 1, res{}, digit{};
	cout << "Enter your number:";
	cin >> num;
	while ((num /  division) != 0)
	{
		division *= 10;
	}
	division /= 10;

	while (division >= 1)
	{
		digit = (num / division) % 10;
		division /= 10;
		if (digit != 3 && digit != 6)
		{
			res = (res * 10) + digit;
		}
	}
		cout << res;
	return 0;
}


int main()
{
	int num{}, num2 = 1;

	cout << "Enter your number:";
	cin >> num;

	while (num2 < num)
	{
		if (num % (num2 * num2) == 0 && num % (num2 * num2 * num2) != 0)
		{
			cout << num2 << endl;
			num2++;
		}
		else
		{
			num2++;
		}
	}
	return 0;
}


int main()
{
	int dig = 1, div = 10, num{}, summ{};
	
	cout << "Enter your number:";
	cin >> num;

	while (num * 10 > div)
	{
		summ += (num % div) / dig;
		div *= 10;
		dig *= 10;

	}
	if (summ * summ * summ == num * num)
	{
		cout << "True";
	}
	else
	{
		cout << "False";
	}
	return 0;
}


int main()
{
	int num{}, num2 = 1;

	cout << "enter your number:";
	cin >> num;

	while (num2 < num)
	{
		if (num % num2 == 0)
		{
			cout << num2 << endl;
			num2++;
		}
		else
		{
			num2++;
		}
	}
	return 0;
}


int main()
{
	size_t num{}, num2{}, x = 1, tmp{};

	cout << "Enter first number:";
	cin >> num;
	cout << "Enter second number:";
	cin >> num2;

	if (num2 > num)
	{
		tmp = num;
		num = num2;
		num2 = tmp;
	}
	while (x < num)
	{
		if (num % x == 0 && num2 % x == 0)
		{
			cout << x << endl;
			x++;
		}
		else
		{
			x++;
		}
	}
	return 0;
}
