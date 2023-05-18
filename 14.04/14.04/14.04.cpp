#include <iostream>
using namespace std;

int max(int* arr1, int* arr2, int len1, int len2)
{
    int max = arr1[0];
    for (int i = 0; i < len1; i++)
    {
        if (arr1[i] > max)
            max = arr1[i];
    }
    for (int i = 0; i < len2; i++)
    {
        if (arr2[i] > max)
            max = arr2[i];
    }
    return max;
}

int min(int* arr1, int* arr2, int len1, int len2)
{
    int min = arr1[0];
    for (int i = 0; i < len1; i++)
    {
        if (arr1[i] < min)
            min = arr1[i];
    }
    for (int i = 0; i < len2; i++)
    {
        if (arr2[i] < min)
            min = arr2[i];
    }
    return min;
}

float avg(int* arr1, int* arr2, int len1, int len2)
{
    float avg{};
    for (int i = 0; i < len1; i++)
    {
        avg += arr1[i];
    }
    for (int i = 0; i < len2; i++)
    {
        avg += arr2[i];
    }
    avg /= (len1 + len2);
    return avg;
}

int Action(int* arr1, int* arr2, int len1, int len2)
{
    int choice{};
    cout << "Enter your choice:\n "
        "1. Max\n"
        "2. Min\n"
        "3. Avg\n";
    cin >> choice;

    switch (choice)
    {
    case 1: {
        return max(arr1, arr2, len1, len2);
    }
    case 2: {
        return min(arr1, arr2, len1, len2);
    }
    case 3: {
        return avg(arr1, arr2, len1, len2);
    }
    }

}



int main()
{
    int len1{}, len2{};
    cout << "Enter len1: "; cin >> len1;
    cout << "Enter len2: "; cin >> len2;
    int* arr1 = new int[len1];
    int* arr2 = new int[len2];
    for (size_t i = 0; i < len1; i++)
    {
        cout << "Enter " << i + 1 << " elem:";
        cin >> arr1[i];
    }
    for (size_t i = 0; i < len2; i++)
    {
        cout << "Enter " << i + 1 << " elem:";
        cin >> arr2[i];
    }

    cout << Action(arr1, arr2, len1, len2);
}