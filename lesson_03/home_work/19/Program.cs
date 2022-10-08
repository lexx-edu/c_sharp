string text_prepare_to_compare(string text){
    text = text.ToLower();
    text = text.Replace(" ", "");
    return text;
}

string reverse(string text){
    char[] reverse_text = text.ToCharArray();
    Array.Reverse(reverse_text);
    return new string(reverse_text);
}

void check_palindrom(string text){
    text = text_prepare_to_compare(text);
    string reverse_text = reverse(text);
    if (text == reverse_text)
        Console.WriteLine("Это палиндром");
    else
        Console.WriteLine("Это не палиндром");    
}

Console.Write("Введите данные для проверки: ");
string users_value = Console.ReadLine();
check_palindrom(users_value);

// А если сделать проверку и отсечь "не числа", то можно так, например:
/*
if (users_value.All(char.IsDigit))
    check_palindrom(users_value);
else
    Console.WriteLine("Это не число");
*/