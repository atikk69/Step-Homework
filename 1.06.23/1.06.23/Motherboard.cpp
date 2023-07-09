#include "MotherBoard.h"

motherBoard::motherBoard(string& _make, string& _model, RAM& _RAM, CPU& _CPU, graphicCard& _graphicCard)
{
	this->make = _make;
	this->model = _model;
	this->raM = new RAM(_RAM);
	this->cpU = new CPU(_CPU);
	this->graphicCarD = new graphicCard(_graphicCard);
}

string motherBoard::getMake() const
{
	return this->make;
}

string motherBoard::getModel() const
{
	return this->model;
}

void motherBoard::printDataMotherBoard() const
{
	cout
		<< "Mother Board make: " << this->make << endl
		<< "Mother Board mpdel: " << this->model << endl;

	this->raM->printDataRAM();
	this->cpU->printDataCPU();
	this->graphicCarD->pruitnDataGraphicCard();
}
