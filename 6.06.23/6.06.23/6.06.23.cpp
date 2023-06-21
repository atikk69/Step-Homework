// 6.06.23.cpp : This file contains the 'main' function. Program execution begins and ends there.
//

#include <iostream>
#include"Classroom.h"
using namespace std;

int main() {

	Classroom room{ 16 };
	room.addStudent("Atilla", "Rustam", "Namik", Birthdate(1, 4, 2007),3,4);

}