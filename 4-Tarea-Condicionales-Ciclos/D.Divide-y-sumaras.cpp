#include <iostream>
using namespace std;

int main() {
  int N;
  cin >> N;
  
  int suma = 0, div = 1;

  while ((N / div) > 0) {
    suma += N / div;
    div *= 2;
  }
  
  cout << suma << endl;

  return 0;
}