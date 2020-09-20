using System.Collections.Generic;
using System.Linq;
using System;

class Program
{
  static void Main(string[] args)
  {
    string entrada = Console.ReadLine();

    int p = int.Parse(entrada.Split(' ')[0]);
    int s = int.Parse(entrada.Split(' ')[1]);
    int r = int.Parse(entrada.Split(' ')[2]);

    int dias = 0;
  
    while (true) {
      dias++;
      p -= s;

      if (p <= 0)
        break;

      p += r;
    }

    Console.WriteLine(dias);
  }
}