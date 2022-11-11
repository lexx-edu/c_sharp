void PrintMatrix(int[,] matrix, string print_name){
    int rows = matrix.GetUpperBound(0) + 1;
    int columns = matrix.Length / rows;

    Console.WriteLine($"\n{print_name}");

    for (int i=0; i<rows; i++){
        for (int j=0; j<columns; j++){
            Console.Write($"{matrix[i, j]}\t");
        }
        Console.WriteLine();
    }
}


void MatrixMultiplication(int[,] matrix_1, int[,] matrix_2){
    int rows = matrix_1.GetUpperBound(0) + 1; // columns для 2й матрицы
    int columns = matrix_1.Length / rows;     // rows для 2й матрицы

    int[,] new_matrix = new int[rows,rows];
    
    for (int i=0; i<rows; i++){
        for (int j=0; j<rows; j++){
            int result = 0;
            for (int k=0; k<columns; k++){
                result += matrix_1[i,k] * matrix_2[k, j];
            }
        new_matrix[i,j] = result;
        }
    }
    PrintMatrix(new_matrix, "Результат перемножения:");
}


int[,] CreateMatrix(int m, int n, string print_name){
    int[,] matrix = new int[m, n];

    for (int i=0; i<m; i++){
        for (int j=0; j<n; j++){
            matrix[i, j] = new Random().Next(1, 5);
        }
    } 
    PrintMatrix(matrix, print_name);
    return matrix;   
}


int m = new Random().Next(3, 11);
int n = 0;

do{
    n = new Random().Next(1, 11);
} while (n < m);

int[,] matrix_1 = CreateMatrix(m, n, "Матрица 1:");
int[,] matrix_2 = CreateMatrix(n, m, "Матрица 2:");

MatrixMultiplication(matrix_1, matrix_2);

Console.WriteLine("\n");