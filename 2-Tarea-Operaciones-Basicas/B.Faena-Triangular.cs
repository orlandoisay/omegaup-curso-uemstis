using System;
class Program
{
  static void Main(string[] args)
  {
    string entrada = Console.ReadLine();
    int a = int.Parse(entrada.Split(' ')[0]);
    int b = int.Parse(entrada.Split(' ')[1]);

    int c = a * a + b * b;
    Console.WriteLine(c);
  }
}