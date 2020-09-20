#include <iostream>
using namespace std;

int main() {
  int N;
  cin >> N;

  int arr[N];
  for (int i = 0; i < N; i++)
    cin >> arr[i];

  bool capicua = true;
  for (int i = 0; i < N; i++)
    capicua = capicua && (arr[i] == arr[N - 1 - i]);

  cout << (capicua ? "SI" : "NO") << endl;

  return 0;
}