#include <iostream>
using namespace std;
class Node {
public:
    int data;
    Node* next;

    Node(int value) {
        data = value;
        next = nullptr;
    }
};

int main() {
    Node* head = new Node(1);
    cout << "Node data: " << head->data << endl;
    return 0;
}
