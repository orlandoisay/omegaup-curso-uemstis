import java.util.Scanner;

public class Main {
  public static void main(String[] args) {
    Scanner scanner = new Scanner(System.in);
    
    int filas = scanner.nextInt();
    int columnas = scanner.nextInt();

    for (int i = 0; i < filas; i++) {
      if (i % 2 == 0) {   // Fila par (ascendente)
        int inicio = columnas * i + 1;

        for (int j = 0; j < columnas; j++)
          System.out.print((inicio + j) + " ");
        System.out.println();
      } else {            // Fila impar (descendente)
        int inicio = columnas * (i + 1);

        for (int j = 0; j < columnas; j++)
          System.out.print((inicio - j) + " ");
        System.out.println();
      }
    } 
  }
}