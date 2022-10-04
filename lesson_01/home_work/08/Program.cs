Console.Write("Введите число: ");
int num = int.Parse(Console.ReadLine());
bool flag = false;

int counter = 1;

while (counter <= num){
    
    if (counter % 2 == 0){
        if (flag)
            Console.Write(", ");
        Console.Write(counter);
        flag = true;
    }

    counter++;
}