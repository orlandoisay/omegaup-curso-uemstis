using System.Collections.Generic;
using System.Linq;
using System;

class Program
{
  static void Main(string[] args)
  {
    double r = double.Parse(Console.ReadLine());
    double h = double.Parse(Console.ReadLine());

    double a = 3.1416 * 2 * r * (h + r);
    double v = 3.1416 * r * r * h;

    Console.WriteLine(string.Format("AREA={0:.00}", a));
    Console.WriteLine(string.Format("VOLUMEN={0:.00}", v));
  }
}