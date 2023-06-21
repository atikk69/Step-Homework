#include "Fraction.h"
Fraction reduction(Fraction& c) {
	int x = 2; 
	while (x * x <= c.numerator && x * x <= c.denominator)
	{
		if (c.numerator % x == 0 && c.denominator % x == 0)
		{
			c.numerator /= x;
			c.denominator /= x;
		}
		else   
			x++;
	} 
	return c;
}
Fraction Fraction::addition(Fraction a, Fraction b)
{
	Fraction c{};
	c.numerator = (a.numerator * b.denominator) + (b.numerator * a.denominator);
	c.denominator = a.denominator * b.denominator;
	return reduction(c);
}

Fraction Fraction::subtraction(Fraction a, Fraction b) {
	Fraction c{};
	c.numerator = (a.numerator * b.denominator) - (b.numerator * a.denominator); 
	c.denominator = a.denominator * b.denominator;
	return reduction(c);
}
Fraction Fraction::multiplication(Fraction a, Fraction b)
{
	Fraction c{};
	c.numerator = a.numerator * b.numerator; 
	c.denominator = a.denominator * b.denominator;
	return reduction(c);
}
Fraction Fraction::division(Fraction a, Fraction b)
{
	Fraction c{};
	c.numerator = a.numerator * b.denominator;
	c.denominator = a.denominator * b.numerator;
	return reduction(c);
}