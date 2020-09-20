using System.Collections.Generic;
using System.Linq;
using System;

class Program
{
  static void Main(string[] args)
  {
    int N = int.Parse(Console.ReadLine());
    int[][] mat = new int[N][];

    for (int i = 0; i < N; i++)
      mat[i] = Console.ReadLine().Split(' ').Select(x => int.Parse(x)).ToArray();
    
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

    Console.WriteLine((magico ? 1 : 0));
  }
}