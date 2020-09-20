#include <iostream>
using namespace std;

int main() {
  int filas, columnas;
  cin >> filas >> columnas;

  int mat[filas][columnas];
  for (int i = 0; i < filas; i++)
    for (int j = 0; j < columnas; j++)
      cin >> mat[i][j];

  for (int j = 0; j < columnas; j++) {
    for (int i = 0; i < filas; i++)
      cout << mat[i][j] << " ";
    cout << endl;
  }

  return 0;
}