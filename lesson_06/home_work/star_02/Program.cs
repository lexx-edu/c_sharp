
void print_array(int[,] array){
    for (int i=0; i<array.GetLength(0); i++){
        Console.WriteLine();
        for (int j=0; j<array.GetLength(1); j++)
            Console.Write($"{array[i, j]} ");
    }
    Console.WriteLine();
    Console.WriteLine();
}

int[,] fill_array(int[,] array){
     for (int i=0; i<array.GetLength(0); i++){
        for (int j=0; j<array.GetLength(1); j++){
            if (j > i){
                array[i, j] = i+1;
                continue;
            }
            array[i, j] = j+1;
        } 
    }
    return array;
}

int n = 0;

Console.Write("Введите n: ");
n = int.Parse(Console.ReadLine());

int[,] array = new int[n, n];
print_array(fill_array(array));

