#include <iostream>
using namespace std;

int main()
{
	char a{};
	cout << "Enter your symbol: ";
	cin >> a;
	if (isdigit(a))
		cout << "Your symbol is number";
	else if (islower(a) || isupper(a))
		cout << "Your symbol is letter";
	else if (ispunct(a))
		cout << "Your symbol is punctuation mark";
	else
		cout << "Your symbol is other";
 
	return 0;
}

int main()
{
	int doxod{}, code{}, Opozdaniye{}, choice{}, shtraf{};
	cout << "1" << endl << "2" << endl << "3" << endl;
	cin >> choice;

	switch (choice)
	{
	case 1:
		cout << "Enter your income:";
		cin >> doxod;
		cout << "Enter your lateness count:";
		cin >> Opozdaniye;
		shtraf = (Opozdaniye / 3) * 20;
		code = (doxod + shtraf) * 2;
		cout << code;
		break;
	case 2:
		cout << "Enter your income:";
		cin >> doxod;
		cout << "Enter your code:";
		cin >> code;
		Opozdaniye = (((code / 2) - doxod) / 20) * 3;
		cout << Opozdaniye;
		break;
	case 3:
		cout << "Enter your code:";
		cin >> code;
		cout << "Enter your lateness count:";
		cin >> Opozdaniye;
		shtraf = (Opozdaniye / 3) * 20;
		doxod = (code / 2) - shtraf;
		cout << doxod;
		break;
	default:
		cout << "Invalid code,lateness count or income";
	}
  	return 0;

}