#include <iostream>
using namespace std;

int main() {
  int I, D;
  cin >> I >> D;

  I %= 5;
  D %= 5;
  int X = (I - D + 5) % 5;

  for (int i = 1; i <= 5; i++) {
    int num = (X + i) % 5;
    if (num == 0) 
      num = 5;
    cout << num << " ";
  }

  return 0;
}