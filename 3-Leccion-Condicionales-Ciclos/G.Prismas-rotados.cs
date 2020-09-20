using System.Collections.Generic;
using System.Linq;
using System;

class Program
{
  static void Main(string[] args)
  {
    string[] prisma1 = Console.ReadLine().Split(' ');

    int a = int.Parse(prisma1[0]);
    int b = int.Parse(prisma1[1]);
    int c = int.Parse(prisma1[2]);

    string[] prisma2 = Console.ReadLine().Split(' ');

    int A = int.Parse(prisma2[0]);
    int B = int.Parse(prisma2[1]);
    int C = int.Parse(prisma2[2]);

    int tmp;

    // Ordena la primera secuencia
    if (a > b) { tmp = a; a = b; b = tmp; }
    if (b > c) { tmp = b; b = c; c = tmp; }
    if (a > b) { tmp = a; a = b; b = tmp; }


    // Ordena la segunda secuencia
    if (A > B) { tmp = A; A = B; B = tmp; }
    if (B > C) { tmp = B; B = C; C = tmp; }
    if (A > B) { tmp = A; A = B; B = tmp; }

    bool iguales =  (a == A && b == B && c == C);

    Console.WriteLine((iguales ? 1 : 0));
  }
}