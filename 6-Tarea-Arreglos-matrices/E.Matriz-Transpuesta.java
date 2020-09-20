import java.util.Scanner;

public class Main {
  public static void main(String[] args) {
    Scanner scanner = new Scanner(System.in);

    int filas = scanner.nextInt();
    int columnas = scanner.nextInt();

    int[][] mat = new int[filas][columnas];
    for (int i = 0; i < filas; i++)
      for (int j = 0; j < columnas; j++)
        mat[i][j] = scanner.nextInt();

    for (int j = 0; j < columnas; j++) {
      for (int i = 0; i < filas; i++)
        System.out.print(mat[i][j] + " ");
      System.out.println();
    }      
  }
}