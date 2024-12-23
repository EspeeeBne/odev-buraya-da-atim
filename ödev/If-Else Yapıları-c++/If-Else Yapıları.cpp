#include <iostream>
using namespace std;

int main() {
    int a;
    cout << "Bir sayi giriniz: ";
    cin >> a;

    if (a > 0) {
        cout << "Pozitif" << endl;
    }
    else {
        cout << "Negatif" << endl;
    }

    return 0;
}
