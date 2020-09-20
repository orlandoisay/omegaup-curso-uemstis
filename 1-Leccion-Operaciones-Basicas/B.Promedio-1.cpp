#include <iostream>
#include <iomanip>
using namespace std;

int main() {
  double A, B;
  cin >> A >> B;
  
  double promedio = (3.5 * A + 7.5 * B) / 11.0;
  cout << "PROMEDIO = " << setprecision(5) << fixed << promedio << endl;

  return 0;
}