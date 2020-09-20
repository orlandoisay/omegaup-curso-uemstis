#include <iostream>
using namespace std;

int main() {
  int filas, columnas;
  cin >> filas >> columnas;

  for (int i = 0; i < filas; i++) {
    if (i % 2 == 0) {   // Fila par (ascendente)
      int inicio = columnas * i + 1;

      for (int j = 0; j < columnas; j++)
        cout << (inicio + j) << " ";
      cout << endl;
    } else {            // Fila impar (descendente)
      int inicio = columnas * (i + 1);

      for (int j = 0; j < columnas; j++)
        cout << (inicio - j) << " ";
      cout << endl;
    } 
  }
}