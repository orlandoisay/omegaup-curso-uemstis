import java.util.Scanner;

public class Main {
  public static void main(String[] args) {
    Scanner scanner = new Scanner(System.in);

    int inferior = scanner.nextInt();
    int superior = scanner.nextInt();

    if (inferior % 2 == 1) 
      inferior++;
    
    if (superior % 2 == 1)
      superior--;

    for (int i = inferior; i <= superior; i += 2)
      System.out.println(i);
  }
}