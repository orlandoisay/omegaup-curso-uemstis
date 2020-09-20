#include <iostream>
using namespace std;

int main() {
  int W, H, X, Y, R, S;
  cin >> W >> H >> X >> Y >> R >> S;

  int fx = (W + X + R) % W;
  int fy = (H + Y + S) % H;

  cout << fx << " " << fy << endl;
  
  return 0;
}