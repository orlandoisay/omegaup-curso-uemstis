using System.Collections.Generic;
using System.Linq;
using System;

class Program
{
  static void Main(string[] args)
  {
    int N = int.Parse(Console.ReadLine());
    int[] arr = Console.ReadLine().Split(' ').Select(x => int.Parse(x)).ToArray();
    int max = -1;

    for (int i = 0; i < N; i++) {
      if (arr[i] > max)
        max = arr[i];
    }

    int K = N;
    for (int i = 0; i < N; i++)
      if (arr[i] == max) K--;

    Console.WriteLine(K);

    for (int i = 0; i < N; i++)
      if (arr[i] != max)
        Console.Write(string.Format("{0} ", arr[i]));
  }
}