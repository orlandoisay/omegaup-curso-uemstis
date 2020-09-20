#include <iostream>
using namespace std;

int main() {
  int N;
  cin >> N;
  int arr[N];

  for (int i = 0; i < N; i++)
    cin >> arr[i];

  int K;
  cin >> K;

  for (int i = 0; i < N - K; i++) {
    bool esElUltimo = i == N - K - 1;
    cout << arr[i] << (esElUltimo ? '\n' : ' ');
  }
}