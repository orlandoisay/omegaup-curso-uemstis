using System.Collections.Generic;
using System.Linq;
using System;

class Program
{
  static void Main(string[] args)
  {
    string entrada = Console.ReadLine();

    int T = int.Parse(entrada.Split(' ')[0]);
    int B = int.Parse(entrada.Split(' ')[1]);

    int resultado = (T + 1) / 2;
    resultado += (T - resultado) % (B - 1);

    Console.WriteLine(resultado);
  }
}