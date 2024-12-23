#include <iostream>
using namespace std;

int main() {
    int a;
    cout << "Bir sayi giriniz: ";
    cin >> a;

    if (a < 0) {
        a = -a;
    }

    cout << "Sayinin mutlak degeri: " << a << endl;

    return 0;
}
