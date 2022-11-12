int Akkerman(int m, int n){
    if (m == 0)
        return n + 1;
    else if ((m != 0) && (n == 0))
        return Akkerman(m - 1, 1);
    else
        return Akkerman(m - 1, Akkerman(m, n - 1));
}

int m = new Random().Next(0, 4);
int n = new Random().Next(0, 4);

Console.WriteLine($"m = {m}; n = {n} -> {Akkerman(m, n)}\n");