import java.util.Scanner;

public class Main {
  public static void main(String[] args) {
    Scanner scanner = new Scanner(System.in);

    int p1 = scanner.nextInt();
    int p2 = scanner.nextInt();
    int p3 = scanner.nextInt();
    int p4 = scanner.nextInt();
    
    boolean sePuedeFormar = 
      (p1 == p2 && p1 == p3) ||
      (p1 == p2 && p1 == p4) ||
      (p1 == p3 && p1 == p4) ||
      (p2 == p3 && p2 == p4);

    if (sePuedeFormar)
      System.out.println(1);
    else
      System.out.println(0);
  }
}