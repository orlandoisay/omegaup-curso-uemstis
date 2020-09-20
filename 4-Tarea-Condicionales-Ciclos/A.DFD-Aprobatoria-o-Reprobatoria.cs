using System.Collections.Generic;
using System.Linq;
using System;

class Program
{
  static void Main(string[] args)
  {
    double calificacion = double.Parse(Console.ReadLine());

    if (calificacion < 6.0)
      Console.WriteLine("Reprobatoria");
    else
      Console.WriteLine("Aprobatoria");
  }
}