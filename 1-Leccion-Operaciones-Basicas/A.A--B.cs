using System.Collections.Generic;
using System.Linq;
using System;

class Program
{
  static void Main(string[] args)
  {
    string entrada = Console.ReadLine();
    int A = int.Parse(entrada.Split(' ')[0]); 
    int B = int.Parse(entrada.Split(' ')[1]);

    
    Console.WriteLine(A + B);
    Console.WriteLine(A - B);
    Console.WriteLine(A * B);
    Console.WriteLine(A / B);
    Console.WriteLine(A % B);
  }
}