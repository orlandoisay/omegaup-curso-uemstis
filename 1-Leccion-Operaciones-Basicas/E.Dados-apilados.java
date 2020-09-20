import java.util.Scanner;

public class Main {
  public static void main(String[] args) {
    Scanner scanner = new Scanner(System.in);

    int D = scanner.nextInt();
    
    int inferior = 14 * D + 1;
    int superior = 14 * D + 6;   

    System.out.print(inferior + " " + superior);
  }
}