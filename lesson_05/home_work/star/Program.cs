void print_array(List<int> array, bool arrow=false){
    if (arrow)
        Console.Write("-> ");
    foreach(int i in array)
        Console.Write($"{i} ");
}


List<int> create_array(int lth=8){
    List<int> arr = new List<int>();
    int i = 0;

    for (i=0; i<lth; i++){
        if (i > 3 && i % 3 == 0) arr.Add(20);
        else arr.Add(new Random().Next(-100, 101));
    }
    
    print_array(arr);
    return arr;
}

int find_first_element(List<int> array, int element=20){
    return array.IndexOf(element);
}

Console.WriteLine();
int length = new Random().Next(10, 20);
int index = 0;

List<int> basic_array = create_array(length);

index = find_first_element(basic_array, 20);
if (index > -1)
    basic_array[index] = 200;

print_array(basic_array, true);
Console.WriteLine();
