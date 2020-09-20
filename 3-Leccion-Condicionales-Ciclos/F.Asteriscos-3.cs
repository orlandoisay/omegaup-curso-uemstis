using System.Collections.Generic;
using System.Linq;
using System;

class Program
{
  static void Main(string[] args)
  {
    int N = int.Parse(Console.ReadLine());

    for (int i = 1; i <= N; i++) {
      // Espacios
      for (int j = 0; j < N - i; j++)
        Console.Write(' ');
      
      // Asteriscos
      for (int j = 0; j < 2 * i - 1; j++)
        Console.Write('*');

      Console.WriteLine();
    }
  }
}