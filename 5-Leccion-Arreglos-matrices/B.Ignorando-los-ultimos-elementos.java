import java.util.Scanner;

public class Main {
  public static void main(String[] args) {
    Scanner scanner = new Scanner(System.in);

    int N = scanner.nextInt();
    int[] arr = new int[N];

    for (int i = 0; i < N; i++)
      arr[i] = scanner.nextInt();

    int K = scanner.nextInt();
    
    for (int i = 0; i < N - K; i++) {
      boolean esElUltimo = i == N - K - 1;
      System.out.print(arr[i] + (esElUltimo ? "\n" : " "));
    }
  }
}