void PrintArray(List<int> array){
    Console.WriteLine();

    foreach(int i in array)
        Console.Write($" {i}  ");
}


List<List<int>> TransposeStructure(List<List<int>> lst){
    int rows = lst[0].Count;
    List<List<int>> newlist = new List<List<int>>();

        for (int j=0; j<rows; j++)
            newlist.Add(new List<int>());

    return newlist;
}


List<List<int>> TransposeList(List<List<int>> lst){
    List<List<int>> trans_list = TransposeStructure(lst);

    for (int i=0; i<lst.Count; i++){
        for (int j=0; j<lst[i].Count; j++){
            trans_list[j].Add(lst[i][j]);
        }
    }

    return trans_list;
}


void AverageColumns(List<List<int>> lst){
    Console.WriteLine("\n");
    
    foreach (List<int> i in TransposeList(lst))
        Console.Write(string.Format("{0:f1} ", Math.Round(i.Average(), 1)));
}


List<int> FillLine(int n){
    List<int> line = new List<int>();

    for (int i=0; i<n; i++)
        line.Add(new Random().Next(0, 10));

    PrintArray(line);
    return line;
}


void CreateArray(int m, int n){
    List<List<int>> lst = new List<List<int>>();

    for (int i=0; i<m; i++){
        List<int> newline = FillLine(n);
        lst.Add(newline);
    }    

    AverageColumns(lst);
}


int m = new Random().Next(2, 11);
int n = new Random().Next(2, 11);

Console.Write("Получен массив:");
CreateArray(m, n);
Console.WriteLine();
