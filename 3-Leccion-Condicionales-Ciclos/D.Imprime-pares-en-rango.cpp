#include <iostream>
using namespace std;

int main() {
  int inferior, superior;
  cin >> inferior >> superior;

  if (inferior % 2) 
    inferior++;
  
  if (superior % 2)
    superior--;

  for (int i = inferior; i <= superior; i += 2)
    cout << i << endl;

  return 0;
}