using System;

class Program
{
  static void Main(string[] args)
  {
    double R = double.Parse(Console.ReadLine());
    double R2 = R + 5;
    double R3 = R2 * R2;
    double R4 = R3 / (R / 3);
    double R5 = R4 * R4 * R4;

    Console.WriteLine("{0:F6} {1:F6} {2:F6} {3:F6} {4:F6}", R, R2, R3, R4, R5);       
  }
}