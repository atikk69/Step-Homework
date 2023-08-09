#include <iostream>
#include <initializer_list>
using namespace std;

template <typename T>
class MyList
{
public:
    struct Node
    {
        T data{};
        Node* next{};
        Node* prev{};

        Node(T data)
        {
            this->data = data;
        }
    };

    MyList() = default;

    MyList(initializer_list<T> list)
    {
        for (const T* it = list.begin(); it < list.end(); ++it)
        {
            push_back(*it);
        }

        Node* current = this->head;
        Node* prev = nullptr;

        while (current != nullptr)
        {
            current->prev = prev;
            prev = current;
            current = current->next;
        }
    }

    void push_front(T data)
    {
        Node* node = new Node{ data };

        if (this->head == nullptr)
        {
            this->head = node;
            this->tail = node;
        }
        else
        {
            node->next = this->head;
            this->head->prev = node;
            this->head = node;
        }
        ++(this->size);
    }

    void push_back(T data)
    {
        Node* node = new Node{ data };

        if (this->head == nullptr)
        {
            this->head = node;
            this->tail = node;
        }
        else
        {
            this->tail->next = node;
            node->prev = this->tail;
            this->tail = node;
        }
        ++(this->size);
    }

    void push_at_index(T data, size_t index)
    {
        if (index > size)
        {
            // Индекс находится за пределами списка
            return;
        }

        if (index == 0)
        {
            push_front(data);
        }
        else if (index == size)
        {
            push_back(data);
        }
        else
        {
            Node* current = head;
            for (size_t i = 0; i < index; ++i)
            {
                current = current->next;
            }

            Node* newNode = new Node{ data };
            newNode->next = current;
            newNode->prev = current->prev;
            current->prev->next = newNode;
            current->prev = newNode;

            ++size;
        }
    }

    void pop_back()
    {
        if (size == 0)
        {
            // Список пуст
            return;
        }

        if (size == 1)
        {
            delete tail;
            head = nullptr;
            tail = nullptr;
            size = 0;
        }
        else
        {
            Node* prevNode = tail->prev;
            prevNode->next = nullptr;
            delete tail;
            tail = prevNode;
            --size;
        }
    }

    void pop_at_index(size_t index)
    {
        if (index >= size)
        {
            // Индекс находится за пределами списка
            return;
        }

        if (index == 0)
        {
            pop_front();
        }
        else if (index == size - 1)
        {
            pop_back();
        }
        else
        {
            Node* current = head;
            for (size_t i = 0; i < index; ++i)
            {
                current = current->next;
            }

            current->prev->next = current->next;
            current->next->prev = current->prev;
            delete current;
            --size;
        }
    }

    void pop_by_value(T value)
    {
        Node* current = head;
        while (current != nullptr)
        {
            if (current->data == value)
            {
                if (current == head)
                {
                    pop_front();
                }
                else if (current == tail)
                {
                    pop_back();
                }
                else
                {
                    current->prev->next = current->next;
                    current->next->prev = current->prev;
                    delete current;
                    --size;
                }
                return;
            }
            current = current->next;
        }
    }

    void print() const
    {
        Node* current = this->head;

        while (current != nullptr)
        {
            cout << current->data << " ";
            current = current->next;
        }
        cout << endl;
    }

private:
    Node* head{};
    Node* tail{};
    size_t size{};

    void pop_front()
    {
        if (size == 0)
        {
            // Список пуст
            return;
        }

        if (size == 1)
        {
            delete head;
            head = nullptr;
            tail = nullptr;
            size = 0;
        }
        else
        {
            Node* nextNode = head->next;
            nextNode->prev = nullptr;
            delete head;
            head = nextNode;
            --size;
        }
    }
};

int main()
{
    MyList<int> list{ 1, 2, 3, 4, 5 };

    list.print();
    list.push_front(0);
    list.print();
    list.push_back(6);
    list.print();
    list.push_at_index(10, 3);
    list.print();
    list.pop_back();
    list.print();
    list.pop_at_index(2);
    list.print();
    list.pop_by_value(2);
    list.print();

    return 0;
}