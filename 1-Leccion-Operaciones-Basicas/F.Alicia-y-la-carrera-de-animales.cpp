#include <iostream>
using namespace std;

int main()
{
  int R, P; 
  cin >> R >> P;
 
  double T = (R * P * 1.0) / (P * 1.0 - R * 1.0);
  cout << T << endl;
  
  return 0;
}