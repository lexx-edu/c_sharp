int counter = 0;
bool indicator = true;
int max_number = 0; // Ругается платформа на определение переменной внутри if =(

while (counter < 3){
    Console.Write($"Введите {counter+1}е число: ");
    int num = int.Parse(Console.ReadLine());

    if (indicator){
        max_number = num;
        indicator = false;
    }
    
    max_number = Math.Max(num, max_number);

    counter++;
} 

Console.WriteLine(max_number);

