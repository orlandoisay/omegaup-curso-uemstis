import java.util.Scanner;

public class Main {
  public static void main(String[] args) {
    Scanner scanner = new Scanner(System.in);

    int T = scanner.nextInt();
    int B = scanner.nextInt();

    int resultado = (T + 1) / 2;
    resultado += (T - resultado) % (B - 1);

    System.out.println(resultado);
  }
}