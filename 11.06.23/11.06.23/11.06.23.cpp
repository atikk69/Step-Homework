#include <iostream>
#include"MyVector.h"
using namespace std;
int main() {

    MyVector<int> v1 = { 2,1 };
    v1.clear();
    cout << v1.getLength();



    return 0;
}
