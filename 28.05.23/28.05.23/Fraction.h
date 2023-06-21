#pragma once 
#include <iostream> 
using namespace std;

class Fraction
{
public:
	int numerator{};
	int denominator{}; 

	Fraction() = default;

	Fraction(int numerator, int denominator)
	{
		this->numerator = numerator;
		this->denominator = denominator;
	}

	Fraction addition(Fraction a, Fraction b);
	Fraction subtraction(Fraction a, Fraction b);
	Fraction multiplication(Fraction a, Fraction b);
	Fraction division(Fraction a, Fraction b);
};