using System.Collections.Generic;
using System.Linq;
using System;

class Program
{
  static void Main(string[] args)
  {
    string entrada = Console.ReadLine();
    int C = int.Parse(entrada.Split(' ')[0]);
    int P = int.Parse(entrada.Split(' ')[1]);
    int H = int.Parse(entrada.Split(' ')[2]);

    int seQueda = P;
    C -= P;

    seQueda += C % (H + 1);

    Console.WriteLine(seQueda);
  }
}