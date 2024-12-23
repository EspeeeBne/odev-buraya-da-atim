#include <iostream>
using namespace std;

int main() {
    int sayi;
    cout << "Bir sayi giriniz: ";
    cin >> sayi;

    if (sayi >= 0 && sayi <= 100) {
        cout << "Gecerli bir sayi girdiniz." << endl;
    }
    else {
        cout << "Gecersiz bir sayi girdiniz." << endl;
    }

    return 0;
}
