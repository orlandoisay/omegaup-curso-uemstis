#include <iostream>
using namespace std;

int main() {
  int N;
  cin >> N;

  int suma = 0;

  for (int i = 0; i < N; i++) {
    int x;
    cin >> x;
    suma += x;
  }

  cout << suma << endl;
}