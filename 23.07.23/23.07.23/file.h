#include "newUser.h"

namespace file
{
	void savetoFile(User* users, uint16_t usersCount)
	{
		FILE* file{};
		fopen_s(&file, "users.txt", "a+");

		if (file == nullptr)
		{
			std::cout << "Error" << std::endl;
			return;
		}

		fprintf(file, "%s", users[usersCount].tostring());

		fclose(file);
	}

	int length(char* obyekt)
	{
		int l{};
		if (obyekt[0] != '\0')
		{
			while (obyekt[l] != '\n')
				l++;
		}

		return l;
	}

	void loadnames(User*& users, uint16_t& usersCount)
	{
		FILE* _users{};
		fopen_s(&_users, "users.txt", "r");

		if (_users == nullptr) {
			return;
		}

		while (!feof(_users)) {
			char data[5][50]{};

			fgets(data[0], 50, _users);
			data[0][length(data[0])] = '\0';
			fgets(data[1], 50, _users);
			data[1][length(data[1])] = '\0';
			fgets(data[2], 50, _users);
			data[2][length(data[2])] = '\0';
			fgets(data[3], 50, _users);
			data[3][length(data[3])] = '\0';
			fgets(data[4], 50, _users);
			data[4][length(data[4])] = '\0';
			users[usersCount] = *new User(data[0], data[1], data[2], data[3], data[4]);

			usersCount++;
		}
		usersCount--;

		fclose(_users);
	}
}