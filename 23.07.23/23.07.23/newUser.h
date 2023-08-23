#include <iostream>

class User {
private:
    std::string name{};
    std::string surname{};
    std::string email{};
    std::string password{};
    std::string phone{};
public:
    User() = default;

    User(std::string& name, std::string& surname, std::string& email, std::string& password, std::string& phone);
    User(char _name[], char _surname[], char _email[], char _password[], char phone[]);

    char* tostring();

    void setName(std::string& _name);
    void setSurname(std::string& _surname);
    void setEmail(std::string& _email);
    void setPassword(std::string& _password);
    void setPhone(std::string& _phone);

    std::string getName() const;
    std::string getSurname() const;
    std::string getEmail() const;
    std::string getPassword() const;
    std::string getPhone() const;
};