#include <iostream>
using namespace std;

int main() {
  int C, P, H;
  cin >> C >> P >> H;

  int seQueda = P;
  C -= P;

  seQueda += C % (H + 1);

  cout << seQueda << endl;

  return 0;
}