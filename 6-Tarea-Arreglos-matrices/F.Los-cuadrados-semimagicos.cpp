#include <iostream>
using namespace std;

int main() {
  int N;
  cin >> N;

  int mat[N][N];
  for (int i = 0; i < N; i++)
    for (int j = 0; j < N; j++)
      cin >> mat[i][j];

  int S = 0, suma;

  for (int i = 0; i < N; i++)
    S += mat[i][i];

  bool magico = true;

  suma = 0;
  for (int i = 0; i < N; i++)
    suma += mat[i][N - 1 - i];

  if (suma != S)
    magico = false;

  for (int i = 0; i < N; i++) {
    suma = 0;

    for (int j = 0; j < N; j++)
      suma += mat[i][j];

    if (suma != S)
      magico = false;
  }

  for (int j = 0; j < N; j++) {
    suma = 0;

    for (int i = 0; i < N; i++)
      suma += mat[i][j];

    if (suma != S)
      magico = false;
  }

  cout << magico << endl;

  return 0;
}