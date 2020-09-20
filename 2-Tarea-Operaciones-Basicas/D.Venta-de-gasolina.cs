using System.Collections.Generic;
using System.Linq;
using System;

class Program
{
  static void Main(string[] args)
  {
    string entrada = Console.ReadLine();

    int L = int.Parse(entrada.Split(' ')[0]);
    int N = int.Parse(entrada.Split(' ')[1]);
    int l = int.Parse(entrada.Split(' ')[2]);
    int m = int.Parse(entrada.Split(' ')[3]);
    int w = int.Parse(entrada.Split(' ')[4]);
    int j = int.Parse(entrada.Split(' ')[5]);
    int v = int.Parse(entrada.Split(' ')[6]);
    int s = int.Parse(entrada.Split(' ')[7]);
    int d = int.Parse(entrada.Split(' ')[8]);

    int d1, d2, d3, d4, d5, d6, d7;

    d1 = L - (N * l);
    d2 = (d1 + L) - (N * m); 
    d3 = (d2 + L) - (N * w); 
    d4 = (d3 + L) - (N * j); 
    d5 = (d4 + L) - (N * v); 
    d6 = (d5 + L) - (N * s); 
    d7 = (d6 + L) - (N * d); 

    Console.WriteLine(string.Format("{0} {1} {2} {3} {4} {5} {6}",
      d1, d2, d3, d4, d5, d6, d7));  
  }
}