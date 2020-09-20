using System.Collections.Generic;
using System.Linq;
using System;

class Program
{
  static void Main(string[] args)
  {
    int C = int.Parse(Console.ReadLine());
    
    int K = C + 273;
    int F = (int)(C * 1.8) + 32;
    int R = (4 * C) / 5;

    Console.WriteLine(string.Format("{0} {1} {2}", K, F, R));
  }
}