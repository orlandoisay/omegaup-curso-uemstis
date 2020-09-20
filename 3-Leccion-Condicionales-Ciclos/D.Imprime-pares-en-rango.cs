using System.Collections.Generic;
using System.Linq;
using System;

class Program
{
  static void Main(string[] args)
  {
    string[] entrada = Console.ReadLine().Split(' ');

    int inferior = entrada[0];
    int superior = entrada[1];

    if (inferior % 2 == 1) 
      inferior++;
    
    if (superior % 2 == 1)
      superior--;

    for (int i = inferior; i <= superior; i += 2)
      Console.WriteLine(i);
  }
}

