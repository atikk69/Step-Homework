#include"file.h"
#include <regex>
#include <Windows.h>

void getClick(int& x, int& y)
{
	HANDLE hConsoleIn = GetStdHandle(STD_INPUT_HANDLE);
	INPUT_RECORD inputRec;
	DWORD events;
	COORD coord;
	bool clicked = false;

	DWORD fdwMode = ENABLE_EXTENDED_FLAGS | ENABLE_WINDOW_INPUT | ENABLE_MOUSE_INPUT;
	SetConsoleMode(hConsoleIn, fdwMode);

	while (!clicked) {

		ReadConsoleInput(hConsoleIn, &inputRec, 1, &events);

		if (inputRec.EventType == MOUSE_EVENT) {
			if (inputRec.Event.MouseEvent.dwButtonState == FROM_LEFT_1ST_BUTTON_PRESSED) {
				coord = inputRec.Event.MouseEvent.dwMousePosition;
				x = coord.X;
				y = coord.Y;
				clicked = true;
			}
		}
		if (GetAsyncKeyState(VK_ESCAPE)) {
			break;
		}
	}
}

std::string getKeyBoard()
{
	HANDLE hConsoleIn = GetStdHandle(STD_INPUT_HANDLE);
	INPUT_RECORD inputRec{};
	DWORD events{};
	COORD coord{};
	bool clicked = false;

	DWORD fdwMode = ENABLE_EXTENDED_FLAGS | ENABLE_WINDOW_INPUT | ENABLE_MOUSE_INPUT;
	SetConsoleMode(hConsoleIn, fdwMode);

	std::string numToString{};

	while (true) {
		ReadConsoleInput(hConsoleIn, &inputRec, 1, &events);

		if (inputRec.EventType == KEY_EVENT && inputRec.Event.KeyEvent.bKeyDown) {
			if (inputRec.Event.KeyEvent.wVirtualKeyCode == VK_RETURN) {
				break;
			}
			else if (inputRec.Event.KeyEvent.wVirtualKeyCode == VK_BACK) {
				if (!numToString.empty()) {
					numToString.pop_back();
					std::cout << "\b \b";
				}
			}
			else if (inputRec.Event.KeyEvent.uChar.AsciiChar >= 32 && inputRec.Event.KeyEvent.uChar.AsciiChar <= 126) {
				std::cout << inputRec.Event.KeyEvent.uChar.AsciiChar;
				numToString += inputRec.Event.KeyEvent.uChar.AsciiChar;
			}
		}
	}

	return numToString;
}

User registration()
{
	std::string name{};
	std::string surname{};
	std::string email{};
	std::string password{};
	std::string phone{};

	std::regex regexNameAndSurname("[a-zA-Z]{3,20}");
	std::regex emailRegex(R"(([a-zA-Z0-9](\.|_)?)+([a-zA-Z0-9])+@([a-zA-Z0-9])+((\.)[a-zA-Z]{2,})+)");
	std::regex regexPassword("[a-zA-Z0-9.]{8,20}");
	std::regex phoneRegex("^[+]994[0-9]{9}$");

	std::cout << "Enter your name: "; name = getKeyBoard(); std::cout << '\n';
	if (!regex_match(name, regexNameAndSurname)) {
		throw std::invalid_argument("Invalid name!");
	}

	std::cout << "Enter your surname: "; surname = getKeyBoard(); std::cout << '\n';
	if (!regex_match(surname, regexNameAndSurname)) {
		throw std::invalid_argument("Invalid surname!");
	}

	std::cout << "Enter your email: "; email = getKeyBoard(); std::cout << '\n';
	if (!regex_match(email, emailRegex)) {
		throw std::invalid_argument("Invalid email!");
	}

	std::cout << "Enter your password: "; password = getKeyBoard(); std::cout << '\n';
	if (!regex_match(password, regexPassword)) {
		throw std::invalid_argument("Invalid password!");
	}

	std::cout << "Enter your phone: "; phone = getKeyBoard(); std::cout << '\n';
	if (!regex_match(phone, phoneRegex)) {
		throw std::invalid_argument("Invalid phone!");
	}

	User u(name, surname, email, password, phone);

	return u;
}

bool login(User* users, uint16_t usersCount)
{
	std::string email{};
	std::string password{};

	std::regex emailRegex(R"(([a-zA-Z0-9](\.|_)?)+([a-zA-Z0-9])+@([a-zA-Z0-9])+((\.)[a-zA-Z]{2,})+)");
	std::regex regexPassword("[a-zA-Z0-9.]{8,20}");

	std::cout << "Enter your email: "; email = getKeyBoard(); std::cout << '\n';
	if (!regex_match(email, emailRegex)) {
		throw std::invalid_argument("Invalid email!");
	}

	std::cout << "Enter your password: "; password = getKeyBoard(); std::cout << '\n';
	if (!regex_match(password, regexPassword)) {
		throw std::invalid_argument("Invalid password!");
	}

	for (size_t i = 0; i < usersCount; i++)
	{
		if (users[i].getEmail() == email)
		{
			if (users[i].getPassword() == password)
				return true;
		}
		else
			throw std::invalid_argument("Invalid Password or Email");
	}
}


int main()
{
	User* users = new User[100]{};
	uint16_t usersCount{};
	file::loadnames(users, usersCount);
	int x{}, y{};

	while (true)
	{
		std::cout << "\t\t\t\t\t\tWelcome!" << std::endl;
		std::cout << "\t\t\t\tSign up\t\t\t\t\tLogin" << std::endl;

		while (y != 1 or x < 32 or x > 38 and x < 72 or x > 76)
			getClick(x, y);

		if (x >= 32 and x <= 38)
		{
			bool regComplated = true;
			while (regComplated)
			{
				try {
					users[usersCount] = registration();
				}
				catch (std::exception& e) {
					std::cout << e.what() << std::endl;
					continue;
				}
				file::savetoFile(users, usersCount);
				regComplated = false;
				usersCount++;
			}
		}
		else
		{
			bool regComplated = true;
			while (regComplated)
			{
				try {
					login(users, usersCount);
				}
				catch (std::exception& e) {
					std::cout << e.what() << std::endl;
					continue;
				}
				std::cout << "Login Complated!";
				regComplated = false;
				Sleep(3000);
			}
		}
		system("cls");
		x = 0, y = 0;
	}

	return 0;
}