// 12.02.cpp : This file contains the 'main' function. Program execution begins and ends there.
//


#include <iostream>
using namespace std;
//Task1
int main()
{
	float R0{},R1{}, R2{}, R3{};

	cout << "Enter R1:";
	cin >> R1;
	cout << "Enter R2:";
	cin >> R2;
	cout << "Enter R3:";
	cin >> R3;
	R0 = 1 / (1 / R1 + 1 / R2 + 1 / R3);
	cout << "R0 = " << R0;
}
//Task2
int main()
{
	
	float Pi = 3.14f, R{}, L{}, S{};
	cout << "Enter circumference: ";
	cin >> L;
	R = L / (2 * Pi);
	S = Pi * R * R;
	cout << "Square = " << S;

	return 0;

}
//Task 3
int main()
{
	float V{}, a{}, t{}, S{};
	cout << "Enter speed: ";
	cin >> V;
	cout << "Enter acceleration: ";
	cin >> a;
	cout << "Enter time: ";
	cin >> t;
	S = V * t + (a * t * t) / 2;
	cout << "Distance = " << S;

	return 0;
}
