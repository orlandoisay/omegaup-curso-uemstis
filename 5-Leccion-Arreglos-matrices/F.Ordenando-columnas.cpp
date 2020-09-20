#include <iostream>
#include <algorithm>
using namespace std;

int main() {
  int filas, columnas;
  cin >> filas >> columnas;

  int mat[columnas][filas];

  for (int i = 0; i < filas; i++)
    for (int j = 0; j < columnas; j++)
      cin >> mat[j][i];

  for (int j = 0; j < columnas; j++)
    sort(mat[j], mat[j] + filas);

  for (int i = 0; i < filas; i++) {
    for (int j = 0; j < columnas; j++)
      cout << mat[j][i] << " ";
    cout << endl;
  }

  return 0;
}