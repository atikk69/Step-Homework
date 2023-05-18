#include <iostream>
using namespace std;


char** goods = new char* [6] {
	new char[20] {"Garlands"},
		new char[20] {"ChristmasTree"},
		new char[20] {"Crackers"},
		new char[20] {"Sparklers"},
		new char[20] {"New Year Lamp"},
		new char[20] {"New Year's cookies"}
};
int Gcount[6]{ 10, 10, 10, 10, 10, 10 };
float prices[6]{ 3, 7, 2, 1, 12, 1.2 };

int ccount{}, choice{};
float balance, overallBalance{}, choice2{}, ccount2{};
bool choicekass = true;
bool paid = false;

int main()
{
	while (choicekass)
	{
		if (Gcount[0] == 0 && Gcount[1] == 0 && Gcount[2] == 0 && Gcount[3] == 0)
		{
			cout << "We have run out of goods((";
			break;
		}

		cout << "Continue: "; cin >> choice2;
		choice = choice2;
		if (choice == 0)
			break;

		choice = 0, balance = 0, ccount = 0;
		bool choicepep = true;
		bool paid{};

		cout << "Hello, what do you want to buy?" << endl;

		for (size_t i = 0; i < 6; i++)
		{
			if (Gcount[i] > 0)
				cout << i + 1 << " - " << goods[i] << '\t' << "Goods and Prices: " << Gcount[i] << " - " << prices[i] << '$' << endl;
		}

		cin >> choice2;
		choice = choice2;

		while (choice > 6 || choice == 0 || choice < 0)
		{
			cout << "This product does not exist, please re-enter: "; cin >> choice2;
			choice = choice2;
			cout << endl;
		}

		while (choicepep)
		{
			switch (choice)
			{
			case 1:
			{
				if (Gcount[0] == 0)
				{
					cout << "We have no garlands left(" << endl;
					cout << "Enter another choice: " << endl; cin >> choice2;
					choice = choice2;
					continue;
				}
				cout << "Enter count product: " << endl; cin >> ccount2;
				ccount = ccount2;

				while (ccount > Gcount[0] || ccount < 0)
				{
					cout << "We don't have that many items, please re-enter: "; cin >> ccount2;
					ccount = ccount2;
					cout << endl;
				}
				balance += prices[0] * ccount;
				Gcount[0] -= ccount;
				break;
			}
			case 2:
			{
				if (Gcount[1] == 0)
				{
					cout << "We have no Christmas Tree left(" << endl;
					cout << "Enter another choice: " << endl; cin >> choice2;
					choice = choice2;
					continue;
				}
				cout << "Enter count product: " << endl; cin >> ccount2;
				ccount = ccount2;

				while (ccount > Gcount[1] || ccount < 0)
				{
					cout << "We don't have that many items, please re-enter: "; cin >> ccount2;
					ccount = ccount2;
					cout << endl;
				}
				balance += prices[1] * ccount;
				Gcount[1] -= ccount;
				break;
			}
			case 3:
			{
				if (Gcount[2] == 0)
				{
					cout << "We have no crackers left(" << endl;
					cout << "Enter another choice: " << endl; cin >> choice2;
					choice = choice2;
					continue;
				}
				cout << "Enter count product: " << endl; cin >> ccount2;
				ccount = ccount2;

				while (ccount > Gcount[2] || ccount < 0)
				{
					cout << "We don't have that many items, please re-enter: "; cin >> ccount2;
					ccount = ccount2;
					cout << endl;
				}
				balance += prices[2] * ccount;
				Gcount[2] -= ccount;
				break;
			}
			case 4:
			{
				if (Gcount[3] == 0)
				{
					cout << "We have no sparklers left(" << endl;
					cout << "Enter another choice: " << endl; cin >> choice2;
					choice = choice2;
					continue;
				}
				cout << "Enter count product: " << endl; cin >> ccount2;
				ccount = ccount2;

				while (ccount > Gcount[3] || ccount < 0)
				{
					cout << "We don't have that many items, please re-enter: "; cin >> ccount2;
					ccount = ccount2;
					cout << endl;
				}
				balance += prices[3] * ccount;
				Gcount[3] -= ccount;
				break;
			}
			case 5:
			{
				if (Gcount[4] == 0)
				{
					cout << "We have no New Year Lamp left(" << endl;
					cout << "Enter another choice: " << endl; cin >> choice2;
					choice = choice2;
					continue;
				}
				cout << "Enter count product: " << endl; cin >> ccount2;
				ccount = ccount2;

				while (ccount > Gcount[4] || ccount < 0)
				{
					cout << "We don't have that many items, please re-enter: "; cin >> ccount2;
					ccount = ccount2;
					cout << endl;
				}
				while (ccount > 3)
				{
					cout << "Discounted items can only buy 3 pieces, please re-enter:"; cin >> ccount2;
					ccount = ccount2;
					cout << endl;
				}
				balance += prices[4] * ccount;
				Gcount[4] -= ccount;
				break;
			}
			case 6:
			{
				if (Gcount[5] == 0)
				{
					cout << "We have no New Year's cookies left(" << endl;
					cout << "Enter another choice: " << endl; cin >> choice2;
					choice = choice2;
					continue;
				}
				cout << "Enter count product: " << endl; cin >> ccount2;
				ccount = ccount2;

				while (ccount > Gcount[5] || ccount < 0)
				{
					cout << "We don't have that many items, please re-enter: "; cin >> ccount2;
					ccount = ccount2;
					cout << endl;
				}
				while (ccount > 3)
				{
					cout << "Discounted items can only buy 3 pieces, please re-enter:"; cin >> ccount2;
					ccount = ccount2;
					cout << endl;
				}
				balance += prices[5] * ccount;
				Gcount[5] -= ccount;
				break;
			}
			}
			cout << "Anything else ?" << endl; cin >> choice2;
			choice = choice2;
			while (choice > 4 || choice < 0)
			{
				cout << "This product does not exist, please re-enter: "; cin >> choice2;
				choice = choice2;
				cout << endl;
			}
			if (choice == 0)
			{
				if (balance > 300)
				{
					cout << "Your purchase is more than 300 dollars, please choose a product as a gift)" << endl;

					for (size_t i = 0; i < 4; i++)
					{
						if (Gcount[i] > 0)
							cout << i + 1 << " - " << goods[i] << endl;
					}
				}
				choicepep = false;
				float discount{};
				cout << "If you have discounts, enter the discount: "; cin >> discount;
				while (discount > 100 || discount < 0)
				{
					cout << "There is no such percentage. Please re-enter discount: "; cin >> discount;
				}
				balance = balance - ((balance / 100) * discount);
				cout << "You must: " << balance << endl;
				overallBalance += balance;
				cout << "Successfully paid: "; cin >> paid;
				if (paid)
					cout << "\a";
				system("cls");
				continue;
			}
		}
	}
	cout << "Over All balance: " << overallBalance << "$";

	return 0;
}