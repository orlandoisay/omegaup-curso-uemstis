using System.Collections.Generic;
using System.Linq;
using System;

class Program
{
  static void Main(string[] args)
  {
    int[] entrada = Console.ReadLine().Split(' ').Select(x => int.Parse(x)).ToArray();
    int I = entrada[0];
    int D = entrada[1];

    I %= 5;
    D %= 5;
    int X = (I - D + 5) % 5;

    for (int i = 1; i <= 5; i++) {
      int num = (X + i) % 5;
      if (num == 0) 
        num = 5;
      Console.Write(string.Format("{0} ", num));
    }    
  }
}