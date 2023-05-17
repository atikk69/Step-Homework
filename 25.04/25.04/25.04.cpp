// 25.04.cpp : This file contains the 'main' function. Program execution begins and ends there.
//

#include<iostream>
using namespace std;


struct book
{
	char* name;
	char* author;
	char* publishing;

	void print()
	{
		cout
			<< name << endl
			<< author << endl
			<< publishing << endl;
	}

	void edit()
	{
		int select{};
		cout
			<< "Enter select change" << endl
			<< "1: Name" << endl
			<< "2: Author" << endl
			<< "3: Publishing" << endl
			<< "4: All" << endl;
		cin >> select;
		getchar();

		switch (select)
		{
		case 1:
			cout << "Enter name: ";
			cin.getline(name, 10);
			break;
		case 2:
			cout << "Enter author: ";
			cin.getline(author, 10);
		case 3:
			cout << "Enter publishing: ";
			cin.getline(publishing, 10);
		case 4:
			cout << "Enter name: ";
			cin.getline(name, 10);

			cout << "Enter author: ";
			cin.getline(author, 10);

			cout << "Enter publishing: ";
			cin.getline(publishing, 10);
		default:
			break;
		}
	}
};


void printBook(book** books)
{
	for (size_t i = 0; books[i] != nullptr; i++)
	{
		cout << "Book number " << i + 1 << ":" << endl;
		books[i]->print();
	}
}

book* createBook(int count)
{
	book* b = new book;

	b->name = new char[11];
	b->author = new char[11];
	b->publishing = new char[11];

	cout << "Enter name: ";
	cin.getline(b->name, 10);

	cout << "Enter author: ";
	cin.getline(b->author, 10);

	cout << "Enter publishing: ";
	cin.getline(b->publishing, 10);

	return b;
}

void searchBookName(book** books)
{
	char search[11]{};
	int len{};

	cout << "Enter name book: "; cin.getline(search, 10);

	while (search[len] != '\0')
		len++;

	for (size_t i = 0; books[i] != nullptr; i++)
	{
		int yes{};
		for (size_t j = 0; j < len; j++)
		{
			if (books[i]->name[j] == search[j])
				yes++;
		}
		if (yes == len)
			cout << "Book numbered: " << i + 1 << endl;
	}
}

void searchBookAuthor(book** books)
{
	char search[11]{};
	int len{};

	cout << "Enter author book: "; cin.getline(search, 10);

	while (search[len] != '\0')
		len++;

	for (size_t i = 0; books[i] != nullptr; i++)
	{
		int yes{};
		for (size_t j = 0; j < len; j++)
		{
			if (books[i]->author[j] == search[j])
				yes++;
		}
		if (yes == len)
			cout << "Book numbered: " << i + 1;
	}
}

void sortName(book** books)
{
	for (size_t i = 0; books[i] != nullptr; i++)
	{
		for (size_t j = 0; books[j] != nullptr; j++)
		{
			if ((int)books[i]->name[0] < (int)books[j]->name[0])
			{
				char* r = books[i]->name;
				books[i]->name = books[j]->name;
				books[j]->name = r;
				r = books[i]->author;
				books[i]->author = books[j]->author;
				books[j]->author = r;
				r = books[i]->publishing;
				books[i]->publishing = books[j]->publishing;
				books[j]->publishing = r;
			}
		}
	}
	printBook(books);
}

void sortAuthor(book** books)
{
	for (size_t i = 0; books[i] != nullptr; i++)
	{
		for (size_t j = 0; books[j] != nullptr; j++)
		{
			if ((int)books[i]->author[0] < (int)books[j]->author[0])
			{
				char* r = books[i]->name;
				books[i]->name = books[j]->name;
				books[j]->name = r;
				r = books[i]->author;
				books[i]->author = books[j]->author;
				books[j]->author = r;
				r = books[i]->publishing;
				books[i]->publishing = books[j]->publishing;
				books[j]->publishing = r;
			}
		}
	}
	printBook(books);
}

void sortPublishing(book** books)
{
	for (size_t i = 0; books[i] != nullptr; i++)
	{
		for (size_t j = 0; books[j] != nullptr; j++)
		{
			if ((int)books[i]->publishing[0] < (int)books[j]->publishing[0])
			{
				char* r = books[i]->name;
				books[i]->name = books[j]->name;
				books[j]->name = r;
				r = books[i]->author;
				books[i]->author = books[j]->author;
				books[j]->author = r;
				r = books[i]->publishing;
				books[i]->publishing = books[j]->publishing;
				books[j]->publishing = r;
			}
		}
	}
	printBook(books);
}

int main()
{
	int count{};
	cout << "How many books do you want to add? "; cin >> count;
	getchar();

	book** books = new book * [10] {};

	for (size_t i = 0; i < count; i++)
	{
		books[i] = createBook(count);
	}
	bool stop = true;
	while (stop)
	{
		int choice{};
		cout
			<< "Enter your choice: " << endl
			<< "1. Edit book" << endl
			<< "2. Print books" << endl
			<< "3. Book search by name" << endl
			<< "4. Search for books by author" << endl
			<< "5. Sorting the array by book title" << endl
			<< "6. Sorting the array by book author" << endl
			<< "7. Sorting the array by book publishing" << endl
			<< "8. Stop programm" << endl;
		cin >> choice;

		switch (choice)
		{
		case 1:
			system("cls");
			printBook(books);
			cout << "Choice book: "; cin >> choice;
			books[choice - 1]->edit();
			break;
		case 2:
			system("cls");
			printBook(books);
			break;
		case 3:
			system("cls");
			getchar();
			searchBookName(books);
			break;
		case 4:
			system("cls");
			getchar();
			searchBookAuthor(books);
			break;
		case 5:
			system("cls");
			getchar();
			sortName(books);
			break;
		case 6:
			system("cls");
			getchar();
			sortAuthor(books);
			break;
		case 7:
			system("cls");
			getchar();
			sortPublishing(books);
			break;
		case 8:
			stop = false;
			break;
		default:
			break;
		}
	}

	return 0;
}