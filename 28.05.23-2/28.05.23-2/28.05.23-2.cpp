#include <iostream>
#include"Student.h"
using namespace std;

int main()
{
	Student student1 = Student("Atilla", "Rustam", "Namik", Birthdate(1, 4, 2007), 513460716, "Baku", "Azerbaijan", "AzMu", "Baku", "Azerbaijan", 1);

	student1.print();
}