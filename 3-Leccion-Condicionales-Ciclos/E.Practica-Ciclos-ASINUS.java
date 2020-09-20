import java.util.Scanner;

public class Main {
  public static void main(String[] args) {
    Scanner scanner = new Scanner(System.in);

    int N = scanner.nextInt();

    int suma = 0;
    for (int i = 0; i < N; i++) {
      int x = scanner.nextInt();
      suma += x;
    }

    System.out.println(suma);
  }
}