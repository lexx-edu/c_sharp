void PrintArray(List<double> array){
    Console.WriteLine();

    foreach(double i in array)
        if (i < 0) Console.Write(string.Format("{0:f1} ", i));
        else Console.Write(string.Format(" {0:f1} ", i));
}


List<double> FillLine(int n){
    List<double> line = new List<double>();

    for (int i=0; i<n; i++)
        line.Add(Math.Round(
                new Random().NextDouble() * 9 - new Random().NextDouble() * 5, 1));

    PrintArray(line);
    return line;
}


void CreateArray(int m, int n){
    List<List<double>> lst = new List<List<double>>();

    for (int i=0; i<m; i++){
        List<double> newline = FillLine(n);
        lst.Add(newline);
    }    
}


int m = new Random().Next(2, 11);
int n = new Random().Next(2, 11);

Console.Write("Получен массив:");
CreateArray(m, n);
Console.WriteLine();
