double iteration_coordinates(double[] A, double[] B, double[] iterator){
    int i = 0;
    double result = 0;

    while (i < iterator.Length){
        result += Math.Pow(B[i] - A[i], 2);
        i++;
    }

    result = Math.Round(Math.Sqrt(result), 2);
    return result;
}

double[] parse_coordinates(string array){
    array = array.Replace(" ", "");
    return Array.ConvertAll(array.Split(','), Double.Parse);
}

double vector_lenght(string A, string B){
    double[] A_arr = parse_coordinates(A);
    double[] B_arr = parse_coordinates(B);

    double result = 0;

    if (B_arr.Length < A_arr.Length) result = iteration_coordinates(A_arr, B_arr, B_arr);
    else result = iteration_coordinates(A_arr, B_arr, A_arr);

    return result;
}

Console.WriteLine();
Console.WriteLine("Введите координаты начальной и конечной точек вектора.");
Console.WriteLine("Значения разделяйте запятыми, десятичные части - точками");
Console.WriteLine();

Console.Write("Введите координаты начальной точки: ");
string A = Console.ReadLine();

Console.Write("Введите координаты конечной точки: ");
string B = Console.ReadLine();

double length = vector_lenght(A, B);
Console.WriteLine(length);
