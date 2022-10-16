void print_array(int[] array){
    foreach(int i in array)
        Console.Write($"{i} ");
    Console.Write("-> ");
}


int[] create_array(int lth=8){
    int[] arr = new int[lth];
    int i = 0;

    for (i=0; i<lth; i++){
        arr[i] = new Random().Next(1, 101);
    }
    
    return arr;
}

int diff_min_max(int[] array){
    int min = array[0];
    int max = array[0];
    
    foreach (var i in array){
        if (i > max) max = i;
        else if (i < min) min = i;
    }

    return max - min;
}


Console.WriteLine();
int length = new Random().Next(10, 20);
int result_diff = 0;

int[] basic_array = create_array(length);
result_diff = diff_min_max(basic_array);

print_array(basic_array);
Console.WriteLine(result_diff);
