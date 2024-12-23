#include <iostream>
using namespace std;

int main() {
    int a;
    cout << "Bir sayi giriniz: ";
    cin >> a;

    a += 10;
    cout << "a += 10 Sonucu: " << a << endl;

    a /= 2;
    cout << "a /= 2 Sonucu: " << a << endl;

    return 0;
}
