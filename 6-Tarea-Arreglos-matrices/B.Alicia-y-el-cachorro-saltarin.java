import java.util.Scanner;

public class Main {
  public static void main(String[] args) {
    Scanner scanner = new Scanner(System.in);

    int N = scanner.nextInt();
    int[] saltos = new int[N];

    for (int i = 0; i < N; i++)
      saltos[i] = scanner.nextInt();

    int A = scanner.nextInt();

    int cachorro = 0, respuesta = 0;
    for (int i = 0; i < N; i++) {
      cachorro += saltos[i];

      if (cachorro == A)
        respuesta++;
    }

    System.out.println(respuesta);
  }
}