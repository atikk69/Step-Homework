#pragma once
#include<iostream>
#include"Student.h"
#include<vector>
using namespace std;

class Classroom {
private:
	uint16_t capacity{};
public:
	uint16_t studentCount{};
	vector<Student> students;

	Classroom() = default;

	Classroom(uint16_t _capacity) {
		this->capacity = _capacity;
	}

	void addStudent(string name, string surname, string patronomic, Birthdate birthdate, uint16_t* groupNumber, uint16_t* averageGrade) {
		Student newStudent{};
		newStudent.name = name;
		newStudent.surname = surname;
		newStudent.patronomic = patronomic;
		newStudent.birthdate = birthdate;
		newStudent.groupNumber = groupNumber;
		newStudent.averageGrade = averageGrade;
		students.push_back(newStudent);
	}
	void printInfo() {
		for (size_t i = 0; students[i].groupNumber != 0; i++)
		{
			students[i].print();
		}
	}



};