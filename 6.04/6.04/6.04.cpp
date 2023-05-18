#include <iostream>
using namespace std;
#include "headerFile.h"



int main()
{
#pragma region task1

        char* str1 = new char[101]{};
        char* str2 = new char[101]{};
    
        cout << "Enter first string: ";
        cin.getline(str1, 100);
        cout << "Enter second string: ";
        cin.getline(str2, 100);
        mystrcmp(str1, str2);

#pragma endregion task1
done
#pragma region task2

    char* str = new char[101] {};

    cout << "Enter string: ";
    cin.getline(str, 100);

    StringToNumber(str);


#pragma endregion task2
    done
#pragma region task3

int len{};
int *number = new int[len];
cout << "Enter count of number: ";
cin >> len;
cout << "Enter your numbers: " << endl;
for ( int i = 0; i < len; i++)
{
    cin >> number[i];
}
for (int i = 0 ; i < len; i++)
{
    cout << number[i] << " ";
}
cout << endl;
cout << NumberToString(number, len);

#pragma endregion task3
done
#pragma region task4

char *str1 = new char[101]{};

cout << "Enter string: ";
cin.getline(str1, 100);

Uppercase(str1);

#pragma endregion task4
done
#pragma region task5

char *str1 = new char[101]{};

cout << "Enter string: ";
cin.getline(str1, 100);

Lowercase(str1);


#pragma endregion task5
done
#pragma region task6

char *str = new char[101]{};

cout << "Enter string: ";
cin.getline(str, 100);


cout << mystrrev (str);




#pragma endregion task6
done


    return 0;
}