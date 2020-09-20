import java.util.Scanner;

public class Main {
  public static void main(String[] args) {
    Scanner scanner = new Scanner(System.in);

    int N = scanner.nextInt();
    int suma = 0, div = 1;

    while ((N / div) > 0) {
      suma += N / div;
      div *= 2;
    }

    System.out.println(suma);
  }
}