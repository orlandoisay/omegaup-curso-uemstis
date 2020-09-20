import java.util.Scanner;

public class Main {
  public static void main(String[] args) {
    Scanner scanner = new Scanner(System.in);

    int N = scanner.nextInt();
    int[] a = new int[N];
    int[] b = new int[N];

    for (int i = 0; i < N; i++)
      a[i] = scanner.nextInt();

    for (int i = 0; i < N; i++)
      b[i] = scanner.nextInt();

    boolean iguales = true;
    for (int i = 0; i < N; i++)
      iguales = iguales && (a[i] == b[i]);

    if (iguales)
      System.out.println(1);
    else
      System.out.println(0);
  }
}