#include <iostream>
using namespace std;

int main() {
    int toplam = 0;
    for (int i = 1; i <= 10; i++) {
        toplam += i;
    }

    cout << "1'den 10'a kadar olan sayilarin toplami: " << toplam << endl;

    return 0;
}
