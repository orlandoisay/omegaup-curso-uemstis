using System.Collections.Generic;
using System.Linq;
using System;

class Program
{
  static void Main(string[] args)
  {
    int[] dimensiones = Console.ReadLine().Split(' ').Select(x => int.Parse(x)).ToArray();
    int filas = dimensiones[0];
    int columnas = dimensiones[1];
    int[][] mat = new int[filas][];

    for (int i = 0; i < filas; i++)
      mat[i] = Console.ReadLine().Split(' ').Select(x => int.Parse(x)).ToArray();

    for (int j = 0; j < columnas; j++) {
      for (int i = 0; i < filas; i++)
        Console.Write(string.Format("{0} ", mat[i][j]));
      Console.WriteLine();
    }
  }
}