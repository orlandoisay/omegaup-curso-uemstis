#include <iostream>
using namespace std;

int main() {
  double R;
  cin >> R;

  double R2 = R + 5;
  double R3 = R2 * R2;
  double R4 = R3 / (R / 3);
  double R5 = R4 * R4 * R4;

  cout << R << " " << R2 << " " << R3 << " " << R4 << " " << R5 << endl;
}