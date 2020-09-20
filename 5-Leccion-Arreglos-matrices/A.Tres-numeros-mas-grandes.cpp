#include <iostream>
#include <algorithm>
using namespace std;

int main() {
  int N;
  cin >> N;

  int num[N];

  for (int i = 0; i < N; i++)
    cin >> num[i];

  sort(num, num + N);

  cout << num[N - 1] << endl;
  cout << num[N - 2] << endl;
  cout << num[N - 3] << endl;

  return 0;
}