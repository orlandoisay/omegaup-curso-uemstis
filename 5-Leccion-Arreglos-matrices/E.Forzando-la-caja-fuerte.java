import java.util.Scanner;

public class Main {
  public static void main(String[] args) {
    Scanner scanner = new Scanner(System.in);

    int I = scanner.nextInt();
    int D = scanner.nextInt();

    I %= 5;
    D %= 5;
    int X = (I - D + 5) % 5;

    for (int i = 1; i <= 5; i++) {
      int num = (X + i) % 5;
      if (num == 0) 
        num = 5;
      System.out.print(num + " ");
    }
  }
}