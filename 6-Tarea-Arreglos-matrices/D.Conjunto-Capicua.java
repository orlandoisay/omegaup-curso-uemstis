import java.util.Scanner;

public class Main {
  public static void main(String[] args) {
    Scanner scanner = new Scanner(System.in);

    int N = scanner.nextInt();
    int[] arr = new int[N];
    
    for (int i = 0; i < N; i++)
      arr[i] = scanner.nextInt();

    boolean capicua = true;
    for (int i = 0; i < N; i++)
      capicua = capicua && (arr[i] == arr[N - 1 - i]);

    System.out.println((capicua ? "SI" : "NO"));
  }
}