#include "Transaction.h"

Transaction::Transaction(std::string& _senderID, std::string& _recipientID, uint16_t& _sendDay, uint16_t& _sendMonth, uint16_t& _sendYear,
	Balance& _sendAmount, uint16_t& _category)
{
	this->senderID = _senderID;
	this->recipientID = _recipientID;
	this->sendDay = new uint16_t{ _sendDay };
	this->sendMonth = new uint16_t{ _sendMonth };
	this->sendYear = new uint16_t{ _sendYear };
	this->sendAmount = new Balance{ _sendAmount };
	this->category = new uint16_t{ _category };
}

Transaction::Transaction()
{
	this->sendDay = new uint16_t{};
	this->sendMonth = new uint16_t{};
	this->sendYear = new uint16_t{};
	this->sendAmount = new Balance{};
	this->category = new uint16_t{};
}

Transaction::Transaction(const Transaction& _other)
{
	this->senderID = _other.senderID;
	this->recipientID = _other.recipientID;
	this->sendDay = new uint16_t{ *_other.sendDay };
	this->sendMonth = new uint16_t{ *_other.sendMonth };
	this->sendYear = new uint16_t{ *_other.sendYear };
	this->sendAmount = new Balance{ *_other.sendAmount };
	this->category = new uint16_t{ *_other.category };
}

std::string Transaction::getSenderID() const
{
	return this->senderID;
}

std::string Transaction::getRecipientID() const
{
	return this->recipientID;
}

uint16_t Transaction::getSendDay() const
{
	return *this->sendDay;
}

uint16_t Transaction::getSendMonth() const
{
	return *this->sendMonth;
}

uint16_t Transaction::getSendYear() const
{
	return *this->sendYear;
}

Balance* Transaction::getSendAmount() const
{
	return this->sendAmount;
}

uint16_t Transaction::getCategory() const
{
	return *this->category;
}