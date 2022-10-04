int counter = 0;
int num = 1;

while (num != 0){
    Console.Write($"Введите {counter+1}е число (для завершения введите 0): ");
    num = int.Parse(Console.ReadLine());

    if (num % 2 == 0)
        Console.WriteLine($"{num} - четное");
    else
        Console.WriteLine($"{num} - нечетное");

    counter++;
} 
