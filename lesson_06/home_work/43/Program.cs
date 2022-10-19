void find_point(double[] coefs){
    if (coefs[0] == coefs[2]){
        Console.WriteLine("Точек пересечения нет, или их - вся прямая");
        return;
    }
    double x = (coefs[1] + coefs[3]) / (coefs[0] + coefs[2]);
    double y = coefs[0] * x + coefs[1];
    Console.WriteLine($"({Math.Round(x, 2)}; {Math.Round(y, 2)})");
}

double[] coefs = new double[4];
string[] coefs_name = {"k1", "b1", "k2", "b2"};

for (int i=0; i<4; i++){
    Console.Write($"Введите {coefs_name[i]}: ");
    coefs[i] = double.Parse(Console.ReadLine());
}

find_point(coefs);