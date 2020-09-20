using System.Collections.Generic;
using System.Linq;
using System;

class Program
{
  static void Main(string[] args)
  {
    int N = int.Parse(Console.ReadLine());
    int[] arreglo = Console.ReadLine().Split(' ').Select(x => int.Parse(x)).ToArray();

    for (int i = N - 1; i >= 0; i--)
      Console.Write(string.Format("{0} ", arreglo[i]));
  }
}