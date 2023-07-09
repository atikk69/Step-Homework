#include "RAM.h"

RAM::RAM(string& _make, string& _model, string& _formFactor, uint16_t& _clockFrequency,
	uint16_t& _throughput, uint16_t& _timings, uint16_t& _volume)
{
	this->make = _make;
	this->model = _model;
	this->formFactor = _formFactor;
	*this->clockFrequency = _clockFrequency;
	*this->throughput = _throughput;
	*this->timings = _timings;
	*this->volume = _volume;
}

string RAM::getMake() const
{
	return this->make;
}

string RAM::getModel() const
{
	return this->model;
}

string RAM::getFormFactor() const
{
	return this->formFactor;
}

uint16_t RAM::getClockFrequency() const
{
	return *this->clockFrequency;
}

uint16_t RAM::getThroughput() const
{
	return *this->throughput;
}

uint16_t RAM::getTimings() const
{
	return *this->timings;
}

uint16_t RAM::getVolume() const
{
	return *this->volume;
}

void RAM::printDataRAM() const
{
	cout
		<< "RAM make: " << this->make << endl
		<< "RAM model: " << this->model << endl
		<< "RAM form factor: " << this->formFactor << endl
		<< "RAM clock frequency: " << *this->clockFrequency << endl
		<< "RAM throughput: " << *this->throughput << endl
		<< "RAM timings: " << *this->timings << endl
		<< "RAM volume: " << *volume << endl;
}