string is_holliday(int num){
    if (num > 5) return "Да";
    else return "Нет";
}

string parse_overdays(int num){
    int new_dow = num % 7;
    return is_holliday(new_dow);
}

string check_weekday(int num){
    string result;
    
    if (num > 7) result = parse_overdays(num);
    else result = is_holliday(num);

    return result;
}

Console.Write("Введите номер дня недели, который хотите проверить: ");
int users_number = int.Parse(Console.ReadLine());

string result = check_weekday(users_number);
Console.WriteLine(result);
