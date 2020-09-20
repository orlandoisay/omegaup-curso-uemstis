#include <iostream>
using namespace std;

int main()
{
  int D;
	cin >> D;

  int inferior = D * 14 + 1;
	int superior = D * 14 + 6;	

  cout << inferior << " " << superior << endl;
  
  return 0;
}