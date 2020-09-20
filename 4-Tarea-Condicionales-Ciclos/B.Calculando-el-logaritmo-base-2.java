import java.util.Scanner;

public class Main {
  public static void main(String[] args) {
    Scanner scanner = new Scanner(System.in);

    int N = scanner.nextInt();
    int log = 0;

    while (N > 1) {
      N /= 2;
      log++;
    }

    System.out.println(log);
  }
}