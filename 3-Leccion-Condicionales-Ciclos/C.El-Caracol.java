import java.util.Scanner;

public class Main {
  public static void main(String[] args) {
    Scanner scanner = new Scanner(System.in);

    int p = scanner.nextInt();
    int s = scanner.nextInt();
    int r = scanner.nextInt();

    int dias = 0;
  
    while (true) {
      dias++;
      p -= s;

      if (p <= 0)
        break;

      p += r;
    }

    System.out.println(dias);
  }
}