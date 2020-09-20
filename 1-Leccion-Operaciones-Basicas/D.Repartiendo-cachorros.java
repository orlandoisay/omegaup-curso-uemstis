import java.util.Scanner;

public class Main {
  public static void main(String[] args) {
    Scanner scanner = new Scanner(System.in);    
   
    int C = scanner.nextInt();
    int P = scanner.nextInt();
    int H = scanner.nextInt();

    int seQueda = P;
    C -= P;

    seQueda += C % (H + 1);

    System.out.println(seQueda);
  }
}