#pragma once
#include"Birthdate.h"
#include<iostream>
#include<string.h>

using namespace std;
class Student {
public:
	string name{};
	string surname{};
	string patronomic{};
	Birthdate birthdate{};
	int phoneNumber{};
	string city{};
	string country{};
	string univerName{};
	string univerCity{};
	string univerCountry{};
	uint16_t groupNumber{};

	Student() = default;

	Student(string name, string surname, string patronomic, Birthdate birthdate, int phoneNumber, string city, string country, string univerNAme, string univerCity, string univerCountry, uint16_t groupNumber) {

		this->name = name;
		this->surname = surname;
		this->patronomic = patronomic;
		this->birthdate = birthdate;
		this->phoneNumber = phoneNumber;
		this->city = city;
		this->country = country;
		this->univerName = univerNAme;
		this->univerCity = univerCity;
		this->univerCountry = univerCountry;
		this->groupNumber = groupNumber;
	}


	void print() const {
		cout <<
			"Name: " << name << endl <<
			"Surname: " << surname << endl <<
			"Patronomic: " << patronomic << endl <<
			"Birthdate: " << birthdate.day << '.' << birthdate.month << '.' << birthdate.year << endl <<
			"Phone number: " << phoneNumber << endl <<
			"City: " << city << endl <<
			"Country: " << country << endl <<
			"University name: " << univerName << endl <<
			"University's city: " << univerCity << endl <<
			"University's country: " << univerCountry << endl <<
			"Group number: " << groupNumber;
	}


	string getName() {
		return name;
	}

	string getSurname() {
		return surname;
	}

	string getPatronomic() {
		return patronomic;
	}

	Birthdate getBirthdate() {
		birthdate.getDay(); birthdate.getMonth(); birthdate.getYear();
	}

	int getPhoneNumber() {
		return phoneNumber;
	}

	string getCity() {
		return city;
	}

	string getCountry() {
		return country;
	}

	string getUniverName() {
		return univerName;
	}

	string getUniverCity() {
		return univerCity;
	}

	string getUniverCountry() {
		return univerCountry;
	}

	uint16_t getGroupNumber() {
		return groupNumber;
	}



	string setName(string name) {
		this->name = name;
	}

	string setSurname(string surname) {
		this->surname = surname;
	}

	int setPhoneNumber(int phoneNumber) {
		this->phoneNumber = phoneNumber;
	}

	string setCity(string city) {
		this->city = city;
	}

	string setCountry(string country) {
		this->country = country;
	}

	string setUniverName(string univerName) {
		this->univerName = univerName;
	}

	string setUniverCity(string univerCity) {
		this->univerCity = univerCity;
	}

	string setUniverCountry(string univerCountry) {
		this->univerCountry = univerCountry;
	}

	uint16_t setGroupNumber(uint16_t groupNumber) {
		this->groupNumber = groupNumber;
	}
};