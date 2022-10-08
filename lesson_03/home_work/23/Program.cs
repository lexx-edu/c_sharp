void cubes(int num, bool comma){
    if (num > 2) 
        cubes(num - 1, true);
    
    Console.Write(Math.Pow(num, 3));
    
    // Не придумал, как следующий шаг решить по другому )
    if (comma) 
        Console.Write(", ");
    else 
        Console.WriteLine();
}

Console.Write("Введите число: ");
int num = int.Parse(Console.ReadLine());
Console.Write($"{num} -> ");

cubes(num, false);