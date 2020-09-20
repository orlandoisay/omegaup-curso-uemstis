using System.Collections.Generic;
using System.Linq;
using System;

class Program
{
  static void Main(string[] args)
  {
    int N = int.Parse(Console.ReadLine());

    int[] num = Console.ReadLine().Split(' ').Select(x => int.Parse(x)).ToArray();

    Array.Sort(num);

    Console.WriteLine(num[N - 1]);
    Console.WriteLine(num[N - 2]);
    Console.WriteLine(num[N - 3]);
  }
}