using System.Collections.Generic;
using System.Linq;
using System;

class Program
{
  static void Main(string[] args)
  {
    int N = int.Parse(Console.ReadLine());
    int[] a = Console.ReadLine().Split(' ').Select(x => int.Parse(x)).ToArray();
    int[] b = Console.ReadLine().Split(' ').Select(x => int.Parse(x)).ToArray();

    bool iguales = true;
    for (int i = 0; i < N; i++)
      iguales = iguales && (a[i] == b[i]);

    if (iguales)
      Console.WriteLine(1);
    else
      Console.WriteLine(0);
  }
}