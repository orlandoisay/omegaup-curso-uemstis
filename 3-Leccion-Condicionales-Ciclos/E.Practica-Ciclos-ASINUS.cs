using System.Collections.Generic;
using System.Linq;
using System;

class Program
{
  static void Main(string[] args)
  {
    int N = int.Parse(Console.ReadLine());

    int suma = 0;
    for (int i = 0; i < N; i++) {
      int x = int.Parse(Console.ReadLine());
      suma += x;
    }
    Console.WriteLine(suma);
  }
}