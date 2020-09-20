import java.util.Scanner;

public class Main {
  public static void main(String[] args) {
    Scanner scanner = new Scanner(System.in);    
    int C = scanner.nextInt();
    
    int K = C + 273;
    int F = (int)(C * 1.8) + 32;
    int R = (4 * C) / 5;

    System.out.println(K + " " + F + " " + R);
  }
}