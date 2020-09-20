using System.Collections.Generic;
using System.Linq;
using System;

class Program
{
  static void Main(string[] args)
  {
    string entrada = Console.ReadLine();

    int R = int.Parse(entrada.Split(' ')[0]);
    int P = int.Parse(entrada.Split(' ')[1]);

    double T = (R * P * 1.0) / (P * 1.0 - R * 1.0);
    Console.WriteLine(T);
  }
}