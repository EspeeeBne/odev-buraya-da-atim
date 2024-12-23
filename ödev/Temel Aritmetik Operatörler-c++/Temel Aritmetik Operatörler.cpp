#include <iostream>
using namespace std;

int main() {
    int a, b, toplam, fark, carpim, bolum;
    cout << "Birinci sayiyi giriniz: ";
    cin >> a;
    cout << "Ikinci sayiyi giriniz: ";
    cin >> b;

    toplam = a + b;
    fark = a - b;
    carpim = a * b;
    bolum = a / b;

    cout << "Toplam: " << toplam << endl;
    cout << "Fark: " << fark << endl;
    cout << "Carpim: " << carpim << endl;
    cout << "Bolum: " << bolum << endl;

    return 0;
}
