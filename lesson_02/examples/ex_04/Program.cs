int max_function(int arg_1, int arg_2, int arg_3){
    int result = arg_1;
    if (arg_2 > result) result = arg_2;
    if (arg_3 > result) result = arg_3;

    return result;
}

int[] arr =  {1, 2, 3, 4, 5, 6, 7, 8, 9};

int result = max_function(max_function(arr[0], arr[1], arr[2]),
                          max_function(arr[3], arr[4], arr[5]),
                          max_function(arr[6], arr[7], arr[8]));

Console.WriteLine(result); 