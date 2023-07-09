#include <string>
#include <iostream>
using namespace std;

class RAM
{
private:
	string make{};
	string model{};
	string formFactor{};
	uint16_t* clockFrequency = new uint16_t{};
	uint16_t* throughput = new uint16_t{};
	uint16_t* timings = new uint16_t{};
	uint16_t* volume = new uint16_t{};
public:
	RAM(string& _make, string& _model, string& _formFactor, uint16_t& _clockFrequency,
		uint16_t& _throughput, uint16_t& _timings, uint16_t& _volume);

	string getMake() const;
	string getModel() const;
	string getFormFactor() const;
	uint16_t getClockFrequency() const;
	uint16_t getThroughput() const;
	uint16_t getTimings() const;
	uint16_t getVolume() const;

	void printDataRAM() const;
};