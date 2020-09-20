import java.util.Scanner;

public class Main {
  public static void main(String[] args) {
    Scanner scanner = new Scanner(System.in);

    int N = scanner.nextInt();
    int[] arr = new int[N];
    int max = -1;

    for (int i = 0; i < N; i++) {
      arr[i] = scanner.nextInt();

      if (arr[i] > max)
        max = arr[i];
    }

    int K = N;
    for (int i = 0; i < N; i++)
      if (arr[i] == max) K--;

    System.out.println(K);

    for (int i = 0; i < N; i++)
      if (arr[i] != max)
        System.out.print(arr[i] + " ");
  }
}