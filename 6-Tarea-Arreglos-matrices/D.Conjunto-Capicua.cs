using System.Collections.Generic;
using System.Linq;
using System;

class Program
{
  static void Main(string[] args)
  {
    int N = int.Parse(Console.ReadLine());
    int[] arr = Console.ReadLine().Split(' ').Select(x => int.Parse(x)).ToArray();
    
    bool capicua = true;
    for (int i = 0; i < N; i++)
      capicua = capicua && (arr[i] == arr[N - 1 - i]);

    Console.WriteLine((capicua ? "SI" : "NO"));
  }
}