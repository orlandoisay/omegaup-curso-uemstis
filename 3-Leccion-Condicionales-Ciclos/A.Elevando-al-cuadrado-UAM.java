import java.util.Scanner; 

public class Main {
  public static void main(String[] args) {
    Scanner scanner = new Scanner(System.in);

    int N = scanner.nextInt();
    int pasos = 0;

    while (N < 30000) {
      pasos++;
      N *= N;
    }

    System.out.println(N + " " + pasos);    
  }
}