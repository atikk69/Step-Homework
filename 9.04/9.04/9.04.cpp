

void getLen(char* arr, int& len)
{
    while (arr[len] != '\0')
        len++;
}

void wordEdit(char* arr)
{

    char* arrEdit = new char[20] {};
    char* arrEditFor = new char[20] {};
    char* arrNew = new char[40] {};


    cout << "Enter the word to be replaced: " << endl;
    cin.getline(arrEdit, 20);


    cout << "What to replace?";
    cin.getline(arrEditFor, 20);


    for (int i = 0, g = 0; i < strlen(arr); i++)
    {
        int count{};
        if (arr[i] == '\0')
            break;

        for (int j = 0, k = i; j < strlen(arrEdit); j++, k++)
        {
            if (arr[k] == arrEdit[j])
                count++;
        }
        if (count == strlen(arrEdit))
        {
            for (int l = 0; l < strlen(arrEditFor); l++)
            {
                arrNew[g] = arrEditFor[l];
                g++;
                i++;
            }
        }
        else
        {
            arrNew[g] = arr[i];
            g++;
        }

    }
    cout << arrNew << endl;

}
        if (arr[i] >= 97 && arr[i] <= 122)
        {
            for (size_t j = 0; j < 26; j++)
            {
                if (letters[j] == arr[i])
                {
                    count[j]++;
                    break;
                }
            }
        }
    }

    while (k != 26)
    {
        if (count[k] > 0)
        {
            cout << char(letters[k]) << " count is " << count[k] << endl;
        }
        k++;
    }
}



void upperLetters(char* arr)
{
    int len{};
    getLen(arr, len);
    if (arr[0] >= 97 && arr[0] <= 122)
    {
        arr[0] = arr[0] - 32;
    }
    for (size_t i = 0; i < len; i++)
    {
        if (arr[i + 1] >= 97 && arr[i + 1] <= 122 && arr[i] == 33 || arr[i] == 46 || arr[i] == 63)
        {
            arr[i + 1] = arr[i + 1] - 32;
        }
    }
    for (size_t i = 0; i < len; i++)
    {
        cout << arr[i];
    }
}


void lettersCount(char* arr)
{
    int len{}, k{};
    getLen(arr, len);
    int* letters = new int [26] {};
    int* count = new int [26] {};
    for (size_t i = 0; i < 26; i++)
    {
        letters[i] = 97 + i;
    }
    for (size_t i = 0; i < len; i++)
    {



void numsCount(char* arr) 
{ 
 int len{}, k{}; 
 getLen(arr, len); 
 int* nums = new int [10] {48,49,50,51,52,53,54,55,56,57}; 
 int* count = new int [10] {}; 
 for (size_t i = 0; i < len; i++) 
 { 
  if (arr[i] >= 48 && arr[i] <= 57 ) 
  { 
   for (size_t j = 0; j < 10; j++) 
   { 
    if (nums[j] == arr[i] ) 
    { 
     count[j]++; 
     break; 
    } 
   } 
  } 
 } 
 
 while ( k != 10) 
 { 
  if (count[k] > 0) 
  { 
   cout << char(nums[k]) << " count is " << count[k] << endl; 
  } 
   k++; 
 } 
 
} 






int main()
{
    char* arr = new char [30] {};
    cout << "Enter text: ";
    cin.getline(arr, 30);
    (arr);
}