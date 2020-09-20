import java.util.Scanner;

public class Main {
  public static void main(String[] args) {
    Scanner scanner = new Scanner(System.in);

    double calificacion = scanner.nextDouble();

    if (calificacion < 6.0)
      System.out.println("Reprobatoria");
    else
      System.out.println("Aprobatoria");
  }
}