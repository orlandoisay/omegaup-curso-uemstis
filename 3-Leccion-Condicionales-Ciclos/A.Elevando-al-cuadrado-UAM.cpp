#include <iostream>
using namespace std;

int main() {
  int N;
  cin >> N;

  int pasos = 0;
  while (N < 30000) {
    pasos++;
    N *= N;
  }

  cout << N << " " << pasos << endl;

  return 0;
}