import java.util.Scanner;

public class Main {
  public static void main(String[] args) {
    Scanner scanner = new Scanner(System.in);

    int N = scanner.nextInt();
    int P = scanner.nextInt();

    P %= 3; // P = P % 3

    int adelante = (N + P) % 3;
    if (adelante == 0) adelante = 3;

    int atras    = (N - P + 3) % 3;
    if (atras    == 0) atras = 3;

    System.out.println(atras + " " + adelante);
  }
}