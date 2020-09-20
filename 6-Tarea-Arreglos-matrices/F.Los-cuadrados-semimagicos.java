import java.util.Scanner;

public class Main {
  public static void main(String[] args) {
    Scanner scanner = new Scanner(System.in);

    int N = scanner.nextInt();
    int[][] mat = new int[N][N];

    for (int i = 0; i < N; i++)
      for (int j = 0; j < N; j++)
        mat[i][j] = scanner.nextInt();

    int S = 0, suma;

    for (int i = 0; i < N; i++)
      S += mat[i][i];

    boolean magico = true;

    suma = 0;
    for (int i = 0; i < N; i++)
      suma += mat[i][N - 1 - i];

    if (suma != S)
      magico = false;

    for (int i = 0; i < N; i++) {
      suma = 0;

      for (int j = 0; j < N; j++)
        suma += mat[i][j];

      if (suma != S)
        magico = false;
    }

    for (int j = 0; j < N; j++) {
      suma = 0;

      for (int i = 0; i < N; i++)
        suma += mat[i][j];

      if (suma != S)
        magico = false;
    }

    System.out.println((magico ? 1 : 0));
  }
}