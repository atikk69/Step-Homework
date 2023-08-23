#include "Car.h"
#include "Bicycle.h"
#include "Carriage.h"



int main() {
    Car car;
    Bicycle bicycle;
    Carriage carriage;


    int passengers = 4;
    int cargo = 100;

    double carPassengerTime = car.calculatePassengerTime(passengers);
    double carCargoTime = car.calculateCargoTime(cargo);
    double carPassengerCost = car.calculatePassengerCost(passengers);
    double carCargoCost = car.calculateCargoCost(cargo);

    double bicyclePassengerTime = bicycle.calculatePassengerTime(passengers);
    double bicycleCargoTime = bicycle.calculateCargoTime(cargo);
    double bicyclePassengerCost = bicycle.calculatePassengerCost(passengers);
    double bicycleCargoCost = bicycle.calculateCargoCost(cargo);

    double carriagePassengerTime = carriage.calculatePassengerTime(passengers);
    double carriageCargoTime = carriage.calculateCargoTime(cargo);
    double carriagePassengerCost = carriage.calculatePassengerCost(passengers);
    double carriageCargoCost = carriage.calculateCargoCost(cargo);


    cout << "Car: " << endl
        << "Passenger transportation time: " << carPassengerTime << " hours " << endl
        << "Shipping Time: " << carCargoTime << " hours " << endl
        << "Passenger transportation cost: " << carPassengerCost << " $ " << endl
        << "Shipping cost: " << carCargoCost << " $ " << endl;

    cout << "Bicycle: " << endl
        << "Passenger transportation time: " << bicyclePassengerTime << " hours" << endl
        << "Shipping Time: " << bicycleCargoTime << " hours" << endl
        << "Passenger transportation cost: " << bicyclePassengerCost << " $ " << endl
        << "Shipping cost: " << bicycleCargoCost << " $ " << endl;

    cout << "Carriage: " << endl
        << "Passenger transportation time: " << carriagePassengerTime << " hours " << endl
        << "Shipping Time: " << carriageCargoTime << " hours " << endl
        << "Passenger transportation cost: " << carriagePassengerCost << " $ " << endl
        << "Shipping cost: " << carriageCargoCost << " $ " << endl;

    return 0;
}