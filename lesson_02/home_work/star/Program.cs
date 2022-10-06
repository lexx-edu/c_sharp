void print_array(int[] container){
    foreach (int num in container){
        Console.Write($"{num} ");
    }
    Console.WriteLine();
}

void arr_rebuild(int[] container, int exceptions_qty){
    int new_lenght = container.Length - exceptions_qty;
    int[] new_arr = new int[new_lenght];
    int new_start = new_lenght - 1;

    foreach(int num in container){
        if (num == 20){
            continue;
        }
        new_arr[new_start] = num;
        new_start--;
    }

    print_array(new_arr);
}

void arr_manipulation(int[] container){
    int count_20 = 0;

    foreach (int num in container) 
        if (num==20) count_20++;
    
    arr_rebuild(container, count_20);
}



int[] arr = {1, 20, 62, 58, 20, 43, 0, 21, 89, 20, 20, 13};
arr_manipulation(arr);
