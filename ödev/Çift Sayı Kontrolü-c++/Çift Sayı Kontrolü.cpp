#include <iostream>
using namespace std;

int main() {
    int sayi;
    cout << "Bir sayi giriniz: ";
    cin >> sayi;

    if (sayi % 2 == 0) {
        cout << "Sayiniz cifttir." << endl;
    }
    else {
        cout << "Sayiniz tektir." << endl;
    }

    return 0;
}
