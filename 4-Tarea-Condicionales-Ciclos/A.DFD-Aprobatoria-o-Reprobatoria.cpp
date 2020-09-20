#include <iostream>
using namespace std;

int main() {
  double calificacion;
  cin >> calificacion;

  if (calificacion < 6.0)
    cout << "Reprobatoria" << endl;
  else
    cout << "Aprobatoria" << endl;

  return 0;
}