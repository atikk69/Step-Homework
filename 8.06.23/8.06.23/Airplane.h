#pragma once 
#include<iostream> 
using namespace std;

class Airplane {
private:
    string make{};
    uint16_t capacity{};
public:
    int passengerCount{};

    Airplane() = default;

    bool operator ==(const Airplane& other) const {
        return this->make == other.make;
    }

    int operator++() {
        return this->passengerCount++;
    }

    int operator--() {
        return this->passengerCount--;
    }

    bool operator >(const Airplane& other) const {
        return this->capacity > other.capacity;
    }
};