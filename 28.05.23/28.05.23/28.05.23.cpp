#include "Fraction.h"
void enter(int& num, int& den) {
	cout << "Enter the numerator of the fraction: "; cin >> num; cout << "Enter the denominator of the fraction: "; cin >> den;
}
void printAnswer(Fraction answer) {
	cout << "Answer numerator: " << answer.numerator << endl
		<< "Answer denominator: " << answer.denominator << endl;
}
int main()
{
	int choice{};
	int num1{}, den1{}, num2{}, den2{};
	enter(num1, den1); 
	Fraction first(num1, den1);
	enter(num2, den2);
	Fraction second(num2, den2);
	cout
		<< "Enter choice: " << endl
		<< "1. Addition" << endl 
		<< "2. Subtraction" << endl
		<< "3. Multiplication" << endl
		<< "4. Divicion" << endl;
	cin >> choice; if (choice > 4 || choice <= 0)
		cout << "Invalid input! Good bye)";
	if (choice == 1)
	{
		Fraction answer = answer.addition(first, second);
		printAnswer(answer);
	}
	else if (choice == 2)
	{
		Fraction answer = answer.subtraction(first, second);
		printAnswer(answer);
	}
	else if (choice == 3)
	{
		Fraction answer = answer.multiplication(first, second);
		printAnswer(answer);
	}
	else if (choice == 4)
	{
		Fraction answer = answer.division(first, second);

		printAnswer(answer);
	}
	return 0;
}