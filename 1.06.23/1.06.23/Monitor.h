#pragma once
#include <string>
#include <iostream>
using namespace std;

class monitor
{
private:
	string make{};
	string model{};
	string screenCover{};
	string brightness{};
	string contrast{};
	uint16_t* maximumResolution = new uint16_t[2]{};
	uint16_t* pixelResponseTime = new uint16_t{};
	uint16_t* pixelSize = new uint16_t{};
	uint16_t* pixelDensity = new uint16_t{};
	uint16_t* maximumScreenRefreshRate = new uint16_t{};
public:
	monitor(string& _make, string& _model, string& screenCover, string& brightness, string& contrast,
		uint16_t& _maximumResolution, uint16_t& _pixelResponseTime, uint16_t& pixelSize,
		uint16_t& pixelDensity, uint16_t& maximumScreenRefreshRate);

	string getMake() const;
	string getModel() const;
	string getScreenCover() const;
	string getBrightness() const;
	string getContrast() const;
	uint16_t getMaximumResolution() const;
	uint16_t getPixelResponseTime() const;
	uint16_t getPixelSize() const;
	uint16_t getPixelDensity() const;
	uint16_t getMaximumScreenRefreshRate() const;

	void printDataMonitor() const;
};