using System.Collections.Generic;
using System.Linq;
using System;

class Program
{
  static void Main(string[] args)
  {
    int N = int.Parse(Console.ReadLine());
    int suma = 0, div = 1;

    while ((N / div) > 0) {
      suma += N / div;
      div *= 2;
    }

    Console.WriteLine(suma);
  }
}