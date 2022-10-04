Console.WriteLine();
Console.WriteLine("Введите массив из 6 произвольных элементов. Затем число К");
Console.WriteLine("Или воспользуйтесь предустановленным, нажав ENTER на первое приглашение");
Console.WriteLine("Дефолтный массив - [8 11 15 8 9 10]");

int[] def = new int[] {8, 11, 15, 8, 9, 10};
bool indicator = true;
string element = "0";
int i = 0;
int[] arr = new int[6];
int k = 10;
int left = 0;
int right = 0;

while (i < 6){
    Console.Write($"Введите {i} элемент:");
    element = Console.ReadLine();

    if (element != ""){
        arr[i] = int.Parse(element);
        i++;
        indicator = false;
        }
    else{
        if (indicator){
            arr = def;
            i = 6;
        }
    }
}

while (k > 6){
    Console.WriteLine("");
    Console.Write("Введите К [0, 6): ");
    k = int.Parse(Console.ReadLine());
}

i = 0;

while (i < 6){
    if (i > k)
        right += arr[i];
    else
        left += arr[i];
    i++;
}

if (left > right)
    Console.WriteLine($"1я часть, т.к. {left} больше {right}");
else if (left < right)
    Console.WriteLine($"2я часть, т.к. {right} больше {left}");
else
    Console.WriteLine($"Не жульничай =)");