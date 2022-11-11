void PrintArray(List<int> array){
    Console.WriteLine();

    foreach(int i in array)
        Console.Write($" {i}  ");
}


List<int> FillLine(int n){
    List<int> line = new List<int>();

    for (int i=0; i<n; i++)
        line.Add(new Random().Next(0, 10));

    PrintArray(line);
    return line;
}


List<List<int>> CreateArray(int m, int n){
    List<List<int>> lst = new List<List<int>>();

    for (int i=0; i<m; i++){
        List<int> newline = FillLine(n);
        lst.Add(newline);
    }    

    return lst;
}


void LinesSum(List<List<int>> arr){
    int index = 0;
    int min_sum = arr[index].Sum();

    for (int i=index; i<arr.Count(); i++){
        if (arr[i].Sum()<min_sum){
            index = i;
            min_sum = arr[i].Sum();
        }
    }

    Console.Write($"Миниальная сумма элементов: {min_sum}, содержится в строке {index}\n");
}


int m = new Random().Next(2, 11);
int n = 0;

while (true){
    n = new Random().Next(2, 11);
    if (n < m)
        break;
}

Console.Write("Получен массив:");
List<List<int>> array = CreateArray(m, n);
Console.WriteLine("\n");

LinesSum(array);
