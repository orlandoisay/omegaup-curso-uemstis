import java.util.Scanner;

public class Main {
  public static void main(String[] args) {
    Scanner scanner = new Scanner(System.in);

    int A = scanner.nextInt();
    int B = A / 100 + 1;
    int C = 3 * B / 4 - 12;
    int E = A % 19 + 1;
    int F = (8 * B + 5) / 25 - (5 + C);
    int G = 5 * A / 4 - (C + 10);
    int H = (11 * E + 20 + F) % 30;

    if (H == 24) {
      H++;
    }

    if (E > 11) {
      H++;
    }

    int I = 44 - H;

    if (I < 21) {
      I += 30;
    }

    int J = I + 7 - (G + I) % 7;

    int D, M;

    if (J <= 31) {
      D = J;
      M = 3;
    } else {
      D = J - 31;
      M = 4;
    }

    System.out.println(D + " " + M);
  }
}