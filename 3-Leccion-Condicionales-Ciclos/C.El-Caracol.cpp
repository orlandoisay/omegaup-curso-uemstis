#include <iostream>
using namespace std;

int main() {
  int p, s, r;
  cin >> p >> s >> r;

  int dias = 0;
  
  while (true) {
    dias++;
    p -= s;

    if (p <= 0)
      break;

    p += r;
  }

  cout << dias << endl;

  return 0;
}