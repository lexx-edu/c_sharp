int enter_number(string mes, bool is_indicator=false){
    bool correct = true;
    int num = 0;
    
    do {
        Console.Write(mes);
        num = int.Parse(Console.ReadLine());
    
        if (is_indicator){
            correct = num >= 0;
        }
    } while (!correct);

    return num;
}

int A = enter_number("Введите основание степени: ");
int B = enter_number("Введите положительный показатель степени: ", true);

double result = Math.Pow(A, B);
Console.WriteLine(result);
