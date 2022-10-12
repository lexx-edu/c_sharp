int sum_num(string num){
    char[] num_arr = num.ToCharArray();
    int result = 0;

    foreach (char i in num_arr)
        result += int.Parse(i.ToString());

    return result;
}


Console.Write("Введите число: ");
string num = Console.ReadLine();

int result = sum_num(num);
Console.WriteLine(result);