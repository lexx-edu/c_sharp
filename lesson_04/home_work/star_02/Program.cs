void arr_print(int[] arr, bool arrow=false){
    for (int i=0; i<arr.Length; i++)
        Console.Write($"{arr[i]} ");
    if (arrow)
        Console.Write("-> ");
    else
        Console.WriteLine();
}  


int[] create_array(){
    int[] result = new int[0];

    int positive = 0;
    int negative = 0;
    int new_num = 0;
    int i = 0;

    while (i<12){
        new_num = new Random().Next(-10, 10);
        if (new_num>0){
            if (positive<6){
                positive++;
                result = result.Concat(new int[] {new_num}).ToArray();
                i++;
            }
        }
        else if (new_num<0){
            if (negative<6){
                negative++;
                result = result.Concat(new int[] {new_num}).ToArray();
                i++;
            }
        }
    }
    return result;
}

int[] array = create_array();
arr_print(array);
