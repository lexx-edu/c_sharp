int[] arr = {1, 2, 3, 5};

int n = arr.Length;
int find = 3;

int index = 0;
while (index < n){
    if (arr[index] == find){
        Console.WriteLine(index);
        break;
    }

    index++;
}