#include <iostream>
using namespace std;

int main() {
  int N;
  cin >> N;

  int a[N], b[N];

  for (int i = 0; i < N; i++) 
    cin >> a[i];
  
  for (int i = 0; i < N; i++) 
    cin >> b[i];

  bool iguales = true;
  for (int i = 0; i < N; i++) 
    iguales = iguales && (a[i] == b[i]);

  if (iguales)
    cout << 1 << endl;
  else
    cout << 0 << endl;

  return 0;
}