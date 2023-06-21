#pragma once
#include<iostream>
using namespace std;
struct Birthdate {
public:
	uint16_t day{};
	uint16_t month{};
	uint16_t year{};

	Birthdate() = default;
	Birthdate(uint16_t day, uint16_t month, uint16_t year) {
		this->day = day;
		this->month = month;
		this->year = year;
	}
	uint16_t getDay() {
		return day;
	}
	uint16_t getMonth() {
		return month;
	}
	uint16_t getYear() {
		return year;
	}
};