using System.Collections.Generic;
using System.Linq;
using System;

class Program
{
  static void Main(string[] args)
  {
    int N = int.Parse(Console.ReadLine());
    int log = 0;

    while (N > 1) {
      N /= 2;
      log++;
    }

    Console.WriteLine(log);
  }
}