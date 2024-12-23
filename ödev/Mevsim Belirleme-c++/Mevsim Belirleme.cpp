#include <iostream>
using namespace std;

int main() {
    int ay;
    cout << "Bir ay numarasi giriniz (1-12): ";
    cin >> ay;

    if (ay >= 3 && ay <= 5) {
        cout << "Ilkbahar" << endl;
    }
    else if (ay >= 6 && ay <= 8) {
        cout << "Yaz" << endl;
    }
    else if (ay >= 9 && ay <= 11) {
        cout << "Sonbahar" << endl;
    }
    else {
        cout << "Kis" << endl;
    }

    return 0;
}
