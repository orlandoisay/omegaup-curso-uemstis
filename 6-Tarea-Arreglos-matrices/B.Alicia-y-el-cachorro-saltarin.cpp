#include <iostream>
using namespace std;

int main() {
  int N;
  cin >> N;

  int saltos[N];
  for (int i = 0; i < N; i++) {
    cin >> saltos[i];
  }

  int A;
  cin >> A;

  int cachorro = 0, respuesta = 0;
  for (int i = 0; i < N; i++) {
    cachorro += saltos[i];

    if (cachorro == A)
      respuesta++;
  }

  cout << respuesta << endl;

  return 0;
}