#include <iostream>
using namespace std;

int main() {
  int a, b, c;
  cin >> a >> b >> c;

  int A, B, C;
  cin >> A >> B >> C;

  int tmp;

  // Ordena la primera secuencia
  if (a > b) tmp = a, a = b, b = tmp;  
  if (b > c) tmp = b, b = c, c = tmp;
  if (a > b) tmp = a, a = b, b = tmp;


  // Ordena la segunda secuencia
  if (A > B) tmp = A, A = B, B = tmp;
  if (B > C) tmp = B, B = C, C = tmp;
  if (A > B) tmp = A, A = B, B = tmp;

  bool iguales =  (a == A && b == B && c == C);

  cout << (iguales ? 1 : 0) << endl;
}