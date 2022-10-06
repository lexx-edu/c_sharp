Console.Write("Введите число: ");
string users_number = Console.ReadLine();

if (users_number.Length < 3)
    Console.WriteLine("Третьей цифры не существует");
else
    Console.WriteLine(users_number[2]);