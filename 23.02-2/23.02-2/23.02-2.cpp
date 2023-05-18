#include <iostream>
using namespace std;
int main()
{
	int start{}, end{}, num{};

	cout << "enter range{from):";
	cin >> start;

	cout << "enter range{to):";
	cin >> end;

	cout << "enter number:";
	cin >> num;

	while (true)
	{
		if (start < num && num < end)
		{
			cout << "your number is in diapazon";
			break;
		}
		else
		{
			cout << "your number is'nt in diapazon.Try again:";
			cin >> num;
		}

	}
	return 0;
}
int main()
{
	float dolls_stock = 10, candies_stock = 10, notebooks_stock = 10, books_stock = 10, dolls_count{}, candies_count{}, notebooks_count{}, books_count{}, discount{}, yes_or_no{}, overallbalance{},
		dolls_price = 8, candies_price = 10, notebooks_price = 12, books_price = 6, choice2{}, choicekassir2{};
	int choice{}, choicekassir = 1;

	while (choicekassir)
	{
		cout << "do you want to work?" << endl;
		cout << "press any num  for yes" << endl;
		cout << "press 0 for no" << endl;
		cin >> choicekassir2;
		choicekassir = choicekassir2;
		if (choicekassir == 0)
		{
			cout << "store income is " << overallbalance << '$';
			break;
		}
		cout
			<< "1.dolls 8$ count: " << dolls_stock << endl
			<< "2.candies 10$ count: " << candies_stock << endl
			<< "3.notebooks 12$ count: " << notebooks_stock << endl
			<< "4.books 6$ count: " << books_stock << endl
			<< "enter choice:";
		cin >> choice2;
		choice = choice2;
		while (choice < 1 || choice > 4)
		{
			cout << "your choice is wrong.try again: ";
			cin >> choice2;
			choice = choice2;
		}
		while (choice)
		{
			switch (choice)
			{
			case 1:
				cout << "enter dolls count: ";
				cin >> dolls_count;
				while (dolls_count > dolls_stock || dolls_count < 0)
				{
					cout << "we don'n have this count of dools.try again:";
					cin >> dolls_count;
				}
				dolls_stock -= dolls_count;
				overallbalance += dolls_price * dolls_count;
				cout << "you must pay " << overallbalance << '$' << endl;
				cout << "do you want buy anything else?" << endl;
				cout << "press 1-4 for choice" << endl;
				cout << "press 0 for finish";
				cin >> choice2;
				choice = choice2;
				if (choice == 0)
				{
					cout << "do you have a discount?" << endl;
					cout << "press 1 for yes" << endl;
					cout << "press 0 for no";
					cin >> yes_or_no;
					if (yes_or_no)
					{
						cout << "enter discount:";
						cin >> discount;
						while (discount < 0 || discount > 99)
						{
							cout << "your discount is wrong.try again: ";
							cin >> discount;
						}
						overallbalance -= (overallbalance * discount) / 100;
					}
					cout << "you have paid sucsecfull!" << endl;
					choice = false;
					continue;
				}
				break;
			case 2:
				cout << "enter candies count: ";
				cin >> candies_count;
				while (candies_count > candies_stock || candies_count < 0)
				{
					cout << "we don'n have this count of candies.try again:";
					cin >> candies_count;
				}
				candies_stock -= candies_count;
				overallbalance += candies_price * candies_count;
				cout << "you must pay " << overallbalance << '$' << endl;
				cout << "do you want buy anything else?" << endl;
				cout << "press 1-4 for choice" << endl;
				cout << "press 0 for finish";
				cin >> choice2;
				choice = choice2;
				if (choice == 0)
				{
					cout << "do you have a discount?" << endl;
					cout << "press 1 for yes" << endl;
					cout << "press 0 for no";
					cin >> yes_or_no;
					if (yes_or_no)
					{
						cout << "enter discount:";
						cin >> discount;
						while (discount < 0 || discount > 99)
						{
							cout << "your discount is wrong.try again: ";
							cin >> discount;
						}
						overallbalance -= (overallbalance * discount) / 100;
					}
					cout << "you have paid sucsecfull!" << endl;
					choice = false;
					continue;
				}
				break;
			case 3:
				cout << "enter notebooks count: ";
				cin >> notebooks_count;
				while (notebooks_count > notebooks_stock || notebooks_count < 0)
				{
					cout << "we don'n have this count of dools.try again:";
					cin >> notebooks_count;
				}
				notebooks_stock -= notebooks_count;
				overallbalance += notebooks_price * notebooks_count;
				cout << "you must pay " << overallbalance << '$' << endl;
				cout << "do you want buy anything else?" << endl;
				cout << "press 1-4 for choice" << endl;
				cout << "press 0 for finish";
				cin >> choice2;
				choice = choice2;
				if (choice == 0)
				{
					cout << "do you have a discount?" << endl;
					cout << "press 1 for yes" << endl;
					cout << "press 0 for no";
					cin >> yes_or_no;
					if (yes_or_no)
					{
						cout << "enter discount:";
						cin >> discount;
						while (discount < 0 || discount > 99)
						{
							cout << "your discount is wrong.try again: ";
							cin >> discount;
						}
						overallbalance -= (overallbalance * discount) / 100;
					}
					cout << "you have paid sucsecfull!" << endl;
					choice = false;
					continue;
				}
				break;

			case 4:
				cout << "enter books count: ";
				cin >> books_count;
				while (books_count > books_stock || books_count < 0)
				{
					cout << "we don'n have this count of books.try again:";
					cin >> books_count;
				}
				books_stock -= books_count;
				overallbalance += books_price * books_count;
				cout << "you must pay " << overallbalance << '$' << endl;
				cout << "do you want buy anything else?" << endl;
				cout << "press 1-4 for choice" << endl;
				cout << "press 0 for finish";
				cin >> choice2;
				choice = choice2;
				if (choice == 0)
				{
					cout << "do you have a discount?" << endl;
					cout << "press 1 for yes" << endl;
					cout << "press 0 for no";
					cin >> yes_or_no;
					if (yes_or_no)
					{
						cout << "enter discount:";
						cin >> discount;
						while (discount < 0 || discount > 99)
						{
							cout << "your discount is wrong.try again: ";
							cin >> discount;
						}
						overallbalance -= (overallbalance * discount) / 100;
					}
					cout << "you have paid sucsecfull!" << endl;
					choice = false;
					continue;
				}
				break;
			}

		}
	}

}