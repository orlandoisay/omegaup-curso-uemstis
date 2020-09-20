using System.Collections.Generic;
using System.Linq;
using System;

class Program
{
  static void Main(string[] args)
  {
    string[] entrada = Console.ReadLine().Split(' ');

    int N = int.Parse(entrada[0]);
    int P = int.Parse(entrada[1]);

    P %= 3; // P = P % 3

    int adelante = (N + P) % 3;
    if (adelante == 0) adelante = 3;

    int atras    = (N - P + 3) % 3;
    if (atras    == 0) atras = 3;

    Console.WriteLine(string.Format("{0} {1}", atras, adelante));
  }
}