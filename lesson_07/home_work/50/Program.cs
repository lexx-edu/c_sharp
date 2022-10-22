void PrintArray(int[,] array){
    Console.WriteLine();
    int result;

    for (int i=0; i<array.GetLength(0); i++){
        for (int j=0; j<array.GetLength(1); j++){
            result = array[i, j];
            
            if (i < 0) Console.Write($"{result} ");
            else Console.Write($" {result} ");
        }
        Console.WriteLine();
    } 
}


int[,] CreateArray(int m, int n){
    int[,] array = new int[m, n];

    for (int i=0; i<m; i++){
        for (int j=0; j<n; j++){
            array[i, j] = new Random().Next(1, 10);
        }
    } 

    return array;   
}


void PrintElement(int[,] array, List<string> position){
    int rows = array.GetLength(0);
    int cols = array.GetLength(1);
    int y = int.Parse(position[0]);
    int x = int.Parse(position[1]);

    if (rows < y | cols < x){
        Console.WriteLine("Здесь такого элемента нет");
        return;
    }

    Console.WriteLine(array[y, x]);
}


void GetPosition(int[,] array){
    Console.Write("Введите позицию элемента, который хотите вывести: ");
    List<string> position = Console.ReadLine().Split(' ').ToList();
    PrintElement(array, position);
}


int m = new Random().Next(2, 11);
int n = new Random().Next(2, 11);

Console.Write("Получен массив:");
int[,] array = CreateArray(m, n);
PrintArray(array);

GetPosition(array);