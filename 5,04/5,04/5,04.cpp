#include <iostream> 
using namespace std;

void getLen(char* arr, int& len)
{
	int i{};
	while (arr[i] != '\0')
	{
		i++;
	}
	len = i;
}


void tab(char* arr)
{
	int len{};
	getLen(arr, len);
	for (size_t i = 0; i < len; i++)
	{
		if (arr[i] == ' ')
			arr[i] = '\t';
	}
}


void count(char* arr)
{
	int len{}, letters{}, nums{}, others{};
	getLen(arr, len);
	for (size_t i = 0; i < len; i++)
	{
		if (int(arr[i]) >= 65 && int(arr[i]) <= 90 || int(arr[i]) >= 97 && int(arr[i]) <= 122)
		{
			letters++;
		}
		else if (int(arr[i]) >= 48 && int(arr[i]) <= 57)
		{
			nums++;
		}
		else
			others++;
	}
	cout
		<< "Letters count: " << letters << endl
		<< "Numbers count: " << nums << endl
		<< "Other symbols count: " << others - 1;
}

void wordsCount(char* arr)
{
	int len{}, words{};
	getLen(arr, len);
	for (size_t i = 0; i < len; i++)
	{
		if (int(arr[i]) >= 65 && int(arr[i]) <= 90 || int(arr[i]) >= 97 && int(arr[i]) <= 122)
		{
			continue;
		}
		words++;
	}
	cout << "Words count: " << words;
}

void polindromWord(char* arr)
{
	int len{};
	getLen(arr, len);
	bool atik{};
	if (len % 2 == 1)
	{
		for (size_t i = 0, j = len - 1; i != j; i++, j--)
		{
			if (arr[i] == arr[j])
				atik = true;
			else
			{
				atik = false;
				break;
			}
		}
	}
	else
	{
		for (size_t i = 0, j = len - 1; i != len / 2; i++, j--)
		{
			if (arr[i] == arr[j])
				atik = true;
			else
			{
				atik = false;
				break;
			}
		}
	}
	if (atik)
		cout << "Your word is polindrom";

	else
		cout << "Your word is not polindrom";
}


int main()
{
	char* arr = new char[30] {};
	cout << "Enter string: "; cin.getline(arr, 30);
	polindromWord(arr);
	return 0;
}

