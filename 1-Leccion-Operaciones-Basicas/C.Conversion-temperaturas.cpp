#include <iostream>
using namespace std;

int main() {
  int C, K, F, R;
  cin >> C;

  K = C + 273;
  F = (int)(1.8 * C) + 32;
  R = (4 * C) / 5;

  cout << K << " " << F << " " << R << endl;

  return 0;
}