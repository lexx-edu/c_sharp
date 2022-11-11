void PrintPython(int[,] matrix){
    int rows = matrix.GetUpperBound(0) + 1;
    int columns = matrix.Length / rows;

    Console.WriteLine();

    for (int i=0; i<rows; i++){
        for (int j=0; j<columns; j++){
            Console.Write($"{matrix[i, j]}\t");
        }
        Console.WriteLine();
    }
}


void MakePython(int n){
    int[,] new_array = new int[n, n];

    int index = n - 1;
    int center = (index / 2);
    new_array[center, center] = n * n;

    int column = -1;
    int row = 0;
    int counter = 1;

    for (int i=0; i<=index/2; i++){
        for (int j=column+1; j<=index-i; j++){
            new_array[row, j] = counter;
            counter++;
            column = j;
        }

        for (int j=row+1; j<=index-i; j++){
            new_array[j, column] = counter;
            counter++;
            row = j;
        }

        for (int j=column-1; j>=i; j--){
            new_array[row, j] = counter;
            counter++;
            column = j;
        }
        
        for (int j=row-1; j>=i+1; j--){
            new_array[j, column] = counter;
            counter++;
            row = j;
        }
    }


    PrintPython(new_array);
}

int m = new Random().Next(2, 10);
MakePython(m);
