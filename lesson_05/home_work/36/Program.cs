void print_array(int[] array){
    foreach(int i in array)
        Console.Write($"{i} ");
    Console.Write("-> ");
}


int[] create_array(int lth=8){
    int[] arr = new int[lth];
    int i = 0;

    for (i=0; i<lth; i++){
        arr[i] = new Random().Next(-100, 101);
    }
    
    return arr;
}

int sum_odd_position_elements(int[] array){
    int result = 0;
    
    for (int i=0; i<array.Length; i++)
        if (i % 2 != 0) result += array[i];
    return result;
}


Console.WriteLine();
int length = new Random().Next(10, 20);
int result_sum = 0;

int[] basic_array = create_array(length);
result_sum = sum_odd_position_elements(basic_array);

print_array(basic_array);
Console.WriteLine(result_sum);
