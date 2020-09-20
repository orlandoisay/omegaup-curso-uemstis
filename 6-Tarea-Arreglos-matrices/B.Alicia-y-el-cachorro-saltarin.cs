using System.Collections.Generic;
using System.Linq;
using System;

class Program
{
  static void Main(string[] args)
  {
    int N = int.Parse(Console.ReadLine());
    int[] saltos = Console.ReadLine().Split(' ').Select(x => int.Parse(x)).ToArray();
    int A = int.Parse(Console.ReadLine());

    int cachorro = 0, respuesta = 0;
    for (int i = 0; i < N; i++) {
      cachorro += saltos[i];

      if (cachorro == A)
        respuesta++;
    }

    Console.WriteLine(respuesta);
  }
}