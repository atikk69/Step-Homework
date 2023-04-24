// 25.04.23.cpp : This file contains the 'main' function. Program execution begins and ends there.
//

#include <iostream>
using namespace std;

void createAnimal(char**& name, uint16_t*& age, char* gender)
{
    cout << "Enter animal name: ";
    cin.getline(*name, 30);

    cout << "Enter age: ";
    cin >> *age;


    cout << "Enter gender: ";
    cin >> gender;
}
struct Animal
{

    char* name = new char[30] {};
    uint16_t age{};
    char gender{};


    void printAnimalInfo() {
        cout
            << "Animal name: " << name << endl
            << "Animal age: " << age << endl
            << "Animal gender: " << gender << endl;
    }
};






struct  zoo {
    uint16_t animalsCount{};
    uint16_t capacity{ 10 };
    char* name = new char[30] {};
    Animal* animals{};

    void createAnimal()
    {
        if (animalsCount < capacity)
        {
            Animal* animal = new Animal{};

            getchar();

            cout << "Enter animal name: ";
            cin.getline(animal->name, 30);

            cout << "Enter car model: ";
            cin >> animal->age;

            cout << "Enter car price: ";
            cin >> animal->gender;

            animals[animalsCount] = *animal;
            animalsCount++;
        }
        else {
            cout << "Zoo is full" << endl;
        }
    }
    void printInfo() {
        cout
            << "There are " << animalsCount << " animals in " << name << " zoo" << endl;
    }
    void ShowAll() {
        for (int i = 0; i < animalsCount; i++) {
            cout << "Animal #" << i + 1 << '\t';
            animals[i].printAnimalInfo();
        }
    }
};



void createZoo(zoo*& Zoo) {

    Zoo = new zoo{};

    cout << "Enter zoo name: ";
    cin.getline(Zoo->name, 30);

    cout << "Enter zoo capacity: ";
    cin >> Zoo->capacity;

    cout << "Enter animals count: ";
    cin >> Zoo->animalsCount;
    getchar();

    Zoo->animals = new Animal[Zoo->capacity]{};
}
