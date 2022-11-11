void PrintArray(int value, int i, int j, int k){
    Console.Write($"{value}({i},{j},{k}) ");
}


void CreateArray(int m){
    int[,,] new_array = new int[m, m, m];
    int counter = 10;

    for (int i = 0; i < new_array.GetLength(0); i++){
        for (int j = 0; j < new_array.GetLength(1); j++){
            for (int k = 0; k < new_array.GetLength(2); k++){
                new_array[i, j, k] = counter;
                counter++;
                PrintArray(counter, i, j, k);
            }
        Console.WriteLine();
        }
    }
}


int m = new Random().Next(2, 5);
CreateArray(m);