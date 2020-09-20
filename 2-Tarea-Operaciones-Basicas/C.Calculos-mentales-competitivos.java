import java.util.Scanner;

public class Main
{
	public static void main(String[] args) {
	    Scanner scanner = new Scanner(System.in);

      double R = scanner.nextDouble();
      double R2 = R + 5;
      double R3 = R2 * R2;
      double R4 = R3 / (R / 3);
      double R5 = R4 * R4 * R4;

      System.out.printf("%.6f %.6f %.6f %.6f %.6f", R, R2, R3, R4, R5);
	}
}