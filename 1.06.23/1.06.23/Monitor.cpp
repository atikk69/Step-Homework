#include "Monitor.h"

monitor::monitor(string& _make, string& _model, string& _screenCover, string& _brightness, string& _contrast,
	uint16_t& _maximumResolution, uint16_t& _pixelResponseTime, uint16_t& _pixelSize,
	uint16_t& _pixelDensity, uint16_t& _maximumScreenRefreshRate)
{
	this->make = _make;
	this->model = _model;
	this->screenCover = _screenCover;
	this->brightness = _brightness;
	this->contrast = _contrast;
	*this->maximumResolution = _maximumResolution;
	*this->pixelResponseTime = _pixelResponseTime;
	*this->pixelSize = _pixelSize;
	*this->pixelDensity = _pixelDensity;
	*this->maximumScreenRefreshRate = _maximumScreenRefreshRate;
}

string monitor::getMake() const
{
	return this->make;
}

string monitor::getModel() const
{
	return this->model;
}

string monitor::getScreenCover() const
{
	return this->screenCover;
}

string monitor::getBrightness() const
{
	return this->brightness;
}

string monitor::getContrast() const
{
	return this->contrast;
}

uint16_t monitor::getMaximumResolution() const
{
	return *this->maximumResolution;
}

uint16_t monitor::getPixelResponseTime() const
{
	return *this->pixelResponseTime;
}

uint16_t monitor::getPixelSize() const
{
	return *this->pixelSize;
}

uint16_t monitor::getPixelDensity() const
{
	return *this->pixelDensity;
}

uint16_t monitor::getMaximumScreenRefreshRate() const
{
	return *this->maximumScreenRefreshRate;
}

void monitor::printDataMonitor() const
{
	cout
		<< "Monitor make: " << this->make << endl
		<< "Monitor model: " << this->model << endl
		<< "Monitor screen cover: " << this->screenCover << endl
		<< "Monitor brightness: " << this->brightness << endl
		<< "Monitor contrast: " << this->contrast << endl
		<< "Monitor maximum resolution: " << *this->maximumResolution << endl
		<< "Monitor pixel response time: " << *this->pixelResponseTime << endl
		<< "Monitor pixel size: " << *this->pixelSize << endl
		<< "Monitor pixel density: " << *this->pixelDensity << endl
		<< "Monitor maximum screen refresh rate: " << *this->maximumScreenRefreshRate << endl;
}