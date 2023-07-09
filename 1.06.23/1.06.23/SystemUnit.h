#include <iostream>
#include <string>
#include "MotherBoard.h"
#include "Storage.h"
#include "PowerUnit.h"
#include "Cooler.h"
using namespace std;

class systemUnit
{
private:
	string make;
	string model;
public:
	motherBoard* motherBoardd{};
	powerUnit* powerUnitt{};
	storageDevice* storageDevicee{};
	Cooler* cooler{};

	systemUnit(string& _make, string& _model, motherBoard& _motherBoard,
		powerUnit& _powerUnit, storageDevice& _storageDevice, Cooler& _cooler);

	string getMake() const;
	string getModel() const;

	void printDataSystemUnit() const;
};