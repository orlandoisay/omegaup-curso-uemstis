#include <iostream>
using namespace std;

int main() {
  int L, N, l, m, w, j, v, s, d;
  cin >> L >> N >> l >> m >> w >> j >> v >> s >> d;

  int d1, d2, d3, d4, d5, d6, d7;

  d1 = L - (N * l);

  d2 = (d1 + L) - (N * m); 
  d3 = (d2 + L) - (N * w); 
  d4 = (d3 + L) - (N * j); 
  d5 = (d4 + L) - (N * v); 
  d6 = (d5 + L) - (N * s); 
  d7 = (d6 + L) - (N * d); 

  printf("%d %d %d %d %d %d %d\n", 
    d1, d2, d3, d4, d5, d6, d7);  
  
  return 0;
}