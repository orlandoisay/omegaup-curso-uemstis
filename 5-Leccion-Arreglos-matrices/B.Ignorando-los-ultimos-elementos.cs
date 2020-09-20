using System.Collections.Generic;
using System.Linq;
using System;

class Program
{
  static void Main(string[] args)
  {
    int N = int.Parse(Console.ReadLine());
    int[] arr = Console.ReadLine().Split(' ').Select(x => int.Parse(x)).ToArray();
    int K = int.Parse(Console.ReadLine());

    for (int i = 0; i < N - K; i++) {
      bool esElUltimo = i == N - K - 1;
      Console.Write(string.Format("{0}{1}", arr[i], (esElUltimo ? "\n" : " ")));
    }
  }
}