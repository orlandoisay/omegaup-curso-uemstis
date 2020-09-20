using System.Collections.Generic;
using System.Linq;
using System;

class Program
{
  static void Main(string[] args)
  {
    double A = double.Parse(Console.ReadLine());
    double B = double.Parse(Console.ReadLine());

    double promedio = (3.5 * A + 7.5 * B) / 11.0;

    Console.WriteLine(string.Format("PROMEDIO = {0:N5}", promedio));
  }
}