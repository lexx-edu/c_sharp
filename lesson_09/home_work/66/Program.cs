int SumDigits(int m, int n){
    if (n > m){
        return n + SumDigits(m, n - 1);
    }
    else return m;
}


int M = new Random().Next(2, 100);
int N = new Random().Next(2, 100);

Console.Write($"M = {M}; N = {N} -> {SumDigits(M, N)}\n");