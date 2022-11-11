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


void SortLine(List<int> line){
    line.Sort();
    line.Reverse();
    PrintArray(line);
}


void SortInLines(List<List<int>> arr){
    foreach (List<int> line in arr){
        SortLine(line);
    }
}


int m = new Random().Next(2, 11);
int n = new Random().Next(2, 11);

Console.Write("Получен массив:");
List<List<int>> array = CreateArray(m, n);
Console.WriteLine("\n\n");

Console.Write("Отсортированы строки:");
SortInLines(array);
Console.WriteLine();
