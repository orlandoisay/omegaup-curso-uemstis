import java.util.Scanner;

public class Main {
  public static void main(String[] args) {
    Scanner scanner = new Scanner(System.in);

    int R = scanner.nextInt();
    int P = scanner.nextInt();

    double T = (R * P * 1.0) / (P * 1.0 - R *1.0);
    System.out.println(T);
  }
}