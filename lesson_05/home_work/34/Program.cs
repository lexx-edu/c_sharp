void print_array(int[] array){
    foreach(int i in array)
        Console.Write($"{i} ");
    Console.Write("-> ");
}


int[] create_array(int lth=8){
    int[] arr = new int[lth];
    int i = 0;

    for (i=0; i<lth; i++){
        arr[i] = new Random().Next(100, 1000);
    }
    
    return arr;
}

int count_even(int[] array){
    int result = 0;
    
    foreach (var i in array)
        if (i % 2 == 0)
            result++;
    return result;
}


Console.WriteLine();
int length = new Random().Next(10, 20);
int evens_count = 0;

int[] basic_array = create_array(length);
evens_count = count_even(basic_array);

print_array(basic_array);
Console.WriteLine(evens_count);
