#pragma once
#include <iostream> 
using namespace std;


template<typename T>
class MyVector {
private:
    T* arr{};
    size_t length{};
    size_t capacity{};
public:
    MyVector(size_t capacity) {
        this->capacity = capacity;
    }

    MyVector(initializer_list<T> list) {
        this->capacity = list.size() * 2;
        this->length = list.size();
        this->arr = new T[this->capacity]{};

        for (auto i = list.begin(); i < list.end(); ++i) {
            this->arr[i - list.begin()] = *i;
        }
    }

    void extension()
    {
        this->capacity *= 2;
        T* new_arr = new T[this->capacity]{};
        for (size_t i = 0; i < this->length; ++i) {
            new_arr[i] = this->arr[i];
        }
        delete[] this->arr;
        this->arr = new_arr;
    }

    void popBack() {
        this->arr[this->length] = 0;
        this->length--;
    }

    void insert(size_t index, T element) {
        T* new_arr = new T[this->capacity + 1]{};
        for (size_t i = 0; i < index; ++i) {
            new_arr[i] = this->arr[i];
        }
        new_arr[index] = element;
        for (size_t i = index + 1; i < this->length; ++i) {
            new_arr[i + 1] = this->arr[i];
        }
    }

    bool empty() {
        if (this->length == 0)
            return 1;
        else
            return 0;
    }

    void clear() {
        this->length = 0;
    }

    void assign(size_t index, T element) {
        this->arr[index] = element;
    }

    void append(T element) {
        if (this->length == this->capacity) {
            extension();
        }
        this->arr[this->length] = element;
        this->length++;
    }

    size_t getCapacity() {
        return this->capacity;
    }

    size_t getLength() {
        return this->length;
    }

    friend ostream& operator<<(ostream& os, MyVector<T>& v) {
        for (size_t i = 0; i < v.length; ++i) {
            os << v.arr[i] << ' ';
        }
        return os;
    }

    T& operator[](size_t index) {
        if (index < this->length) {
            return this->arr[index];
        }
    }
};
