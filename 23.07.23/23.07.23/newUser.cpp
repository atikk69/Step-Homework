#include "newUser.h"

User::User(std::string& name, std::string& surname, std::string& email, std::string& password, std::string& phone) {
    this->name = name;
    this->surname = surname;
    this->email = email;
    this->password = password;
    this->phone = phone;
}

User::User(char _name[], char _surname[], char _email[], char _password[], char _phone[])
{
    this->name = _name;
    this->surname = _surname;
    this->email = _email;
    this->password = _password;
    this->phone = _phone;
}

char* User::tostring()
{
    char* str = new char[250] {};
    char data[5][50]{};
    name.copy(data[0], sizeof(name));
    surname.copy(data[1], sizeof(surname));
    email.copy(data[2], sizeof(email));
    password.copy(data[3], sizeof(password));
    phone.copy(data[4], sizeof(phone));
    sprintf_s(str, 250, "%s\n%s\n%s\n%s\n%s\n", data[0], data[1], data[2], data[3], data[4]);
    return str;
}


void User::setName(std::string& _name)
{
    this->name = _name;
}

void User::setSurname(std::string& _surname)
{
    this->surname = _surname;
}

void User::setEmail(std::string& _email)
{
    this->email = _email;
}

void User::setPassword(std::string& _password)
{
    this->password = _password;
}

void User::setPhone(std::string& _phone)
{
    this->phone = _phone;
}

std::string User::getName() const {
    return this->name;
}

std::string User::getSurname() const {
    return this->surname;
}

std::string User::getEmail() const {
    return this->email;
}

std::string User::getPassword() const {
    return this->password;
}

std::string User::getPhone() const {
    return this->phone;
}