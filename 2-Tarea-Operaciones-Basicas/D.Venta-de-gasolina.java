import java.util.Scanner;

public class Main {    
  public static void main(String[] args) {    
    Scanner entrada = new Scanner(System.in);        
      
    int L = entrada.nextInt();
    int N = entrada.nextInt();
    int l = entrada.nextInt();
    int m = entrada.nextInt();
    int w = entrada.nextInt();
    int j = entrada.nextInt();
    int v = entrada.nextInt();
    int s = entrada.nextInt();
    int d = entrada.nextInt();

    int d1, d2, d3, d4, d5, d6, d7;

    d1 = L - (N * l);
    d2 = (d1 + L) - (N * m); 
    d3 = (d2 + L) - (N * w); 
    d4 = (d3 + L) - (N * j); 
    d5 = (d4 + L) - (N * v); 
    d6 = (d5 + L) - (N * s); 
    d7 = (d6 + L) - (N * d); 

    System.out.printf("%d %d %d %d %d %d %d", 
      d1, d2, d3, d4, d5, d6, d7);        
  }    
}