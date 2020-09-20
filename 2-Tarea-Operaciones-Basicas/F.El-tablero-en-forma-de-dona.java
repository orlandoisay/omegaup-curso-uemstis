import java.util.Scanner;

public class Main {
    public static void main(String[] args) {
        Scanner t = new Scanner(System.in);

        int W = t.nextInt();
        int H = t.nextInt();
        int X = t.nextInt();
        int Y = t.nextInt();
        int R = t.nextInt();
        int S = t.nextInt();
        
        int fx = (W + X + R) % W;
        int fy = (H + Y + S) % H;
        
        System.out.println(fx + " " + fy);
    }
}