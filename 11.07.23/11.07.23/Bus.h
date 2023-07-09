#include <iostream>

using namespace std;

template<typename T>
class BinaryTree {
public:
    struct Node {
        T data{};
        Node* left{};
        Node* right{};

        Node(T data) : data(data) {}
    };


    BinaryTree() = default;

    BinaryTree(T data) {
        this->root = new Node(data);
    }

    bool tryAdd(T data) {
        if (this->root == nullptr) {
            this->root = new Node(data);
            return true;
        }
        else {
            Node* current = this->root;
            while (true) {
                if (data < current->data) {
                    if (current->left == nullptr) {
                        current->left = new Node(data);
                        return true;
                    }
                    else {
                        current = current->left;
                    }
                }
                else if (data > current->data) {
                    if (current->right == nullptr) {
                        current->right = new Node(data);
                        return true;
                    }
                    else {
                        current = current->right;
                    }
                }
                else {
                    return false;
                }
            }
        }
    }
    void search(T data)
    {
        Node* current = this->root;
        while (true)
        {
            if (current->data > data)
            {
                current = current->left;
                cout << "1";
            }
            else if (current->data < data)
            {
                current = current->right;
                cout << "1";
            }
            else
            {
                cout << "Your nomer is nayden";
            }
        }
    }

    void deletion(T data)
    {
        search(data)





    }
private:
    Node* root{};
};


int main() {


    return 0;
}