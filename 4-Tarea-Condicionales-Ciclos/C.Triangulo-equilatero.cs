using System.Collections.Generic;
using System.Linq;
using System;

class Program
{
  static void Main(string[] args)
  {
    string[] entrada = Console.ReadLine().Split(' ');

    int p1 = int.Parse(entrada[0]);
    int p2 = int.Parse(entrada[1]);
    int p3 = int.Parse(entrada[2]);
    int p4 = int.Parse(entrada[3]);
    
    bool sePuedeFormar = 
      (p1 == p2 && p1 == p3) ||
      (p1 == p2 && p1 == p4) ||
      (p1 == p3 && p1 == p4) ||
      (p2 == p3 && p2 == p4);

    if (sePuedeFormar)
      Console.WriteLine(1);
    else
      Console.WriteLine(0);
  }
}