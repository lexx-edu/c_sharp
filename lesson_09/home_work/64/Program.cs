void SumDigits(int n){
    if (n > 1){
        Console.Write($"{n}, ");
        SumDigits(n - 1);
    }
    else Console.Write("1");
}


int N = new Random().Next(2, 100);
Console.Write($"N = {N} -> ");
SumDigits(N);

Console.WriteLine();
