using System.Collections.Generic;
using System.Linq;
using System;

class Program
{
  static void Main(string[] args)
  {
    int D = int.Parse(Console.ReadLine());
    
    int inferior = 14 * D + 1;
    int superior = 14 * D + 6;

    Console.WriteLine(string.Format("{0} {1}", inferior, superior));
  }
}