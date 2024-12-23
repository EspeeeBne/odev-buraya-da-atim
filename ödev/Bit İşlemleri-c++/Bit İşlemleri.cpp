#include <iostream>
using namespace std;

int main() {
    int a, b, xorSonuc, andSonuc, orSonuc, sagaKaydir;
    cout << "Birinci sayiyi giriniz: ";
    cin >> a;
    cout << "Ikinci sayiyi giriniz: ";
    cin >> b;

    xorSonuc = a ^ b;
    andSonuc = a & b;
    orSonuc = a | b;
    sagaKaydir = a >> 1;

    cout << "XOR Sonucu: " << xorSonuc << endl;
    cout << "AND Sonucu: " << andSonuc << endl;
    cout << "OR Sonucu: " << orSonuc << endl;
    cout << "Saga Kaydirma Sonucu: " << sagaKaydir << endl;

    return 0;
}
