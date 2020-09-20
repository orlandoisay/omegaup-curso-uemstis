import java.util.Scanner;

public class Main {
  public static void main(String[] args) {
    Scanner scanner = new Scanner(System.in);

    double A = scanner.nextDouble();
    double B = scanner.nextDouble();

    double promedio = (3.5 * A + 7.5 * B) / 11.0;

    System.out.printf("PROMEDIO = %.5f\n", promedio);
  }
}