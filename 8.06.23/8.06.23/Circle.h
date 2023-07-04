#pragma once 
#include<iostream> 
using namespace std;

class Circle {
public:
	uint16_t radius{};
	float length = radius * 3.14;

	Circle() = default;

	bool operator ==(const Circle& other) const {
		return this->radius == other.radius;
	}
	bool operator!=(const Circle& other) const {
		return !(*this != other);
	}
	bool operator >(const Circle& other) const {
		return this->length > other.length;
	}

	bool operator +=(const Circle& other) {
		return this->radius += other.radius;
	}

	bool operator -=(const Circle& other) {
		return this->radius -= other.radius;
	}
};