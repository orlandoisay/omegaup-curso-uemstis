using System.Collections.Generic;
using System.Linq;
using System;

class Program
{
  static void Main(string[] args)
  {
    int N = int.Parse(Console.ReadLine());
    int pasos = 0;

    while (N < 30000) {
      pasos++;
      N *= N;
    }

    Console.WriteLine(string.Format("{0} {1}", N, pasos));
  }
}