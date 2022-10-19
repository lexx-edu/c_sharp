
string users_num = "test";
int counter = 0;

while (true){
    Console.Write("Введите число (или нажмите ENTER чтобы закончить: ");
    users_num = Console.ReadLine();

    if (users_num == "") break;
    if (double.Parse(users_num) > 0) counter++;
}

Console.WriteLine(counter);
