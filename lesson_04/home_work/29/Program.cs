void print_array(int[] array, bool arrow=true){
    if (arrow) Console.Write("-> ");
    foreach(int i in array)
        Console.Write($"{i} ");
}

int sum_num(string num){
    char[] num_arr = num.ToCharArray();
    int result = 0;

    foreach (char i in num_arr)
        result += int.Parse(i.ToString());
    return result;
}

int[] prepare_array(int[] array, bool print=true){
    int i = 0;
    int[] arr_result = new int[array.Length];

    for (i=0; i<array.Length; i++){
        arr_result[i] = sum_num(array[i].ToString());
        if (print)
            Console.Write($"{array[i]} ");
    }
    if (print)
        print_array(arr_result);
    return arr_result;
}

int[] create_array(int lth=8){
    int[] arr = new int[lth];
    int i = 0;

    for (i=0; i<lth; i++){
        arr[i] = new Random().Next(0, 100);
    }
    
    return arr;
}


Console.WriteLine();

int[] basic_array = create_array();
int[] result_array = prepare_array(basic_array);

Console.WriteLine();
