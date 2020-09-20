#include <iostream>
using namespace std;

int main() {
  int p1, p2, p3, p4;
  cin >> p1 >> p2 >> p3 >> p4;

  bool sePuedeFormar = 
    (p1 == p2 && p1 == p3) ||
    (p1 == p2 && p1 == p4) ||
    (p1 == p3 && p1 == p4) ||
    (p2 == p3 && p2 == p4);

  if (sePuedeFormar)
    cout << 1 << endl;
  else
    cout << 0 << endl;

  return 0;
}