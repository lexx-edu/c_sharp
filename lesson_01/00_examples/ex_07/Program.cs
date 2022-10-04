Console.Write("Введите ваше имя: ");
string username = Console.ReadLine();

if (username.ToLower() == "маугли"){
    Console.WriteLine("Wow!!! Тебя реально зовут Маугли?");
}
else {
    Console.Write("Привет, ");
    Console.Write(username);
}
