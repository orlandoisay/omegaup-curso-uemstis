using System.Collections.Generic;
using System.Linq;
using System;

class Program
{
  static void Main(string[] args)
  {
    int[] entrada = Console.ReadLine().Split(' ').Select(x => int.Parse(x)).ToArray();
    int filas = entrada[0];
    int columnas = entrada[1];

    for (int i = 0; i < filas; i++) {
      if (i % 2 == 0) {   // Fila par (ascendente)
        int inicio = columnas * i + 1;

        for (int j = 0; j < columnas; j++)
          Console.Write(string.Format("{0}{1}", inicio + j, " "));
        Console.WriteLine();
      } else {            // Fila impar (descendente)
        int inicio = columnas * (i + 1);

        for (int j = 0; j < columnas; j++)
          Console.Write(string.Format("{0}{1}", inicio - j, " "));
        Console.WriteLine();
      }
    } 
  }
}