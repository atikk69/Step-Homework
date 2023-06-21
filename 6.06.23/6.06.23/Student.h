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
	uint16_t* groupNumber = new uint16_t{};
	uint16_t* averageGrade = new uint16_t{};
	Student() = default;

	Student(string name, string surname, string patronomic, Birthdate birthdate,uint16_t groupNumber, uint16_t averageGrade) {

		this->name = name;
		this->surname = surname;
		this->patronomic = patronomic;
		this->birthdate = birthdate;
		*this->groupNumber = groupNumber;
		*this->averageGrade = averageGrade;
	}


	void print() const {
		cout 
			<< "Name: " << name << endl
			<< "Surname: " << surname << endl
			<< "Patronomic: " << patronomic << endl 
			<< "Birthdate: " << birthdate.day << '.' << birthdate.month << '.' 
			<< birthdate.year << endl
			<< "Group number: " << *groupNumber << endl
			<< "Average grade: " << *averageGrade;
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


	uint16_t getGroupNumber() {
		return *groupNumber;
	}

	uint16_t getAverageGrade() {
		return *averageGrade;
	}

	string setName(string name) {
		this->name = name;
	}

	string setSurname(string surname) {
		this->surname = surname;
	}

	uint16_t setGroupNumber(uint16_t groupNumber) {
		*this->groupNumber = groupNumber;
	}

	uint16_t setAverageGrade(uint16_t averageGrade) {
		*this->averageGrade = averageGrade;
	}

	bool operator <(Student& other) {
		return this->averageGrade < other.averageGrade;
	}
	bool operator >(Student& other) {
		return this->averageGrade > other.averageGrade;
	}
	bool operator ==(Student& other) {
		return this->name == other.name && this->surname == other.surname 
			&& this->patronomic == other.patronomic && this->birthdate.day == other.birthdate.day 
			&& this->birthdate.month == other.birthdate.month && this->birthdate.year == other.birthdate.year 
			&& this->groupNumber == other.groupNumber && this->averageGrade == other.averageGrade;
    }
	bool operator !=(Student& other) {
		return !(*this == other);
	}


	friend istream& operator >> (istream& is, Student& student) {
		cout << "Enter name: ";
		is >> student.name;

		cout << "Enter surname: ";
		is >> student.surname;

		cout << "Enter patronomic: ";
		is >> student.patronomic;

		cout << "Enter Birthdate: ";
		is >> student.birthdate.day >> student.birthdate.month >> student.birthdate.year;

		cout << "Enter group number: ";
		is >> *student.groupNumber;

		cout << "Enter average grade: ";
		is >> *student.averageGrade;
		return is;
	}




	friend ostream& operator << (ostream& os, const Student& student) {
		os << student.name << ' ' << student.surname << ' ' << student.birthdate.day << ' ' << student.birthdate.month
			<< ' ' << student.birthdate.year << ' ' << student.groupNumber
			<< ' ' << student.averageGrade;
		return os;
	}



};