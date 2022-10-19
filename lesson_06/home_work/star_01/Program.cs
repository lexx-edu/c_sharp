int power(int a, int n){
    if (n > 1) return a * power(a, n-1);
    return a;
}

int a = 0;
int n = 0;

do {
    Console.Write("Введите положительное основание степени: ");
    a = int.Parse(Console.ReadLine());
} while (a<1);

do {
    Console.Write("Введите положительный показатель степени: ");
    n = int.Parse(Console.ReadLine());
} while (n<1);

Console.WriteLine(power(a, n));