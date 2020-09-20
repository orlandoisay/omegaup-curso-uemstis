import java.util.Scanner;
public class Main {
  public static void main(String[] args) {
    Scanner scanner = new Scanner(System.in);

    int a = scanner.nextInt();
    int b = scanner.nextInt();
    int c = scanner.nextInt();
    int A = scanner.nextInt();
    int B = scanner.nextInt();
    int C = scanner.nextInt();

    int tmp;

    // Ordena la primera secuencia
    if (a > b) { tmp = a; a = b; b = tmp; }
    if (b > c) { tmp = b; b = c; c = tmp; }
    if (a > b) { tmp = a; a = b; b = tmp; }


    // Ordena la segunda secuencia
    if (A > B) { tmp = A; A = B; B = tmp; }
    if (B > C) { tmp = B; B = C; C = tmp; }
    if (A > B) { tmp = A; A = B; B = tmp; }

    boolean iguales =  (a == A && b == B && c == C);

    System.out.println(iguales ? 1 : 0);
  }
}