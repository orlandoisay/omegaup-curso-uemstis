#include <iostream>
#include <iomanip>
using namespace std;

int main()
{
  double r, h, v, a;
  cin >> r >> h;
  
  a = 3.1416 * 2 * r * (h + r);
  v = 3.1416 * r * r * h;
  
  cout << setprecision(2) << fixed << "AREA=" << a << endl;
	cout << setprecision(2) << fixed << "VOLUMEN=" << v << endl;

  return 0;
}