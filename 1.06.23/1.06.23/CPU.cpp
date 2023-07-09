#include "CPU.h"

CPU::CPU(string& _make, string& _model, uint16_t& _frequency, string& _performance, string& _socket)
{
	this->make = _make;
	this->model = _model;
	*this->frequency = _frequency;
	this->performance = _performance;
	this->socket = _socket;
}

string CPU::getMake() const
{
	return this->make;
}

string CPU::getModel() const
{
	return this->model;
}

uint16_t CPU::getFrequency() const
{
	return *this->frequency;
}

string CPU::getPerformance() const
{
	return this->performance;
}

string CPU::getSocket() const
{
	return this->socket;
}

void CPU::printDataCPU() const
{
	cout
		<< "CPU make: " << this->make << endl
		<< "CPU model: " << this->model << endl
		<< "CPU frequency: " << *this->frequency << endl
		<< "CPU performance: " << this->performance << endl
		<< "CPU socket: " << this->socket << endl;
}