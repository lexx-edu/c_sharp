void arr_print(int[] arr, bool arrow=false){
    for (int i=0; i<arr.Length; i++)
        Console.Write($"{arr[i]} ");
    if (arrow)
        Console.Write("-> ");
    else
        Console.WriteLine();
}


int[] split(int[] arr){
    int[] zeros = new int[0];
    int[] non_zeros = new int[0];

    for (int i=0; i<arr.Length; i++){
        if (arr[i]==0) zeros = zeros.Concat(new int[] {0}).ToArray();   
        else non_zeros = non_zeros.Concat(new int[] {arr[i]}).ToArray();  
    }
    return zeros.Concat(non_zeros).ToArray();
}

int[] array = {-1, -3, 0, -1, -3, -1, 0, -4, -2};

arr_print(array, true);
arr_print(split(array));
