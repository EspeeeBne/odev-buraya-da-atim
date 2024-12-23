#include <iostream>
using namespace std;

int main() {
    int a, b, c;
    cout << "Birinci sayiyi giriniz: ";
    cin >> a;
    cout << "Ikinci sayiyi giriniz: ";
    cin >> b;
    cout << "Ucuncu sayiyi giriniz: ";
    cin >> c;

    if (a > b && a > c) {
        cout << "En buyuk sayi: " << a << endl;
    }
    else if (b > c) {
        cout << "En buyuk sayi: " << b << endl;
    }
    else {
        cout << "En buyuk sayi: " << c << endl;
    }

    return 0;
}
