using System.Collections.Generic;
using System.Linq;
using System;

class Program
{
  static void Main(string[] args)
  {
    string entrada = Console.ReadLine();

    int W = int.Parse(entrada.Split(' ')[0]);
    int H = int.Parse(entrada.Split(' ')[1]);
    int X = int.Parse(entrada.Split(' ')[2]);
    int Y = int.Parse(entrada.Split(' ')[3]);
    int R = int.Parse(entrada.Split(' ')[4]);
    int S = int.Parse(entrada.Split(' ')[5]);

    int fx = (W + X + R) % W;
    int fy = (H + Y + S) % H;

    Console.WriteLine(string.Format("{0} {1}", fx, fy));
  }
}