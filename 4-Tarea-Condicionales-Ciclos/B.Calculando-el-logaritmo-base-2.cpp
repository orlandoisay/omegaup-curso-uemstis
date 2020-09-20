#include <iostream>
using namespace std;

int main() {
  int N, log = 0;
  cin >> N;

  while (N > 1) {
    N /= 2;
    log++;
  }

  cout << log << endl;

  return 0;
}