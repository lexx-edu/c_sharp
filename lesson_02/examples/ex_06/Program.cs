
void PrintArray(int[] collection){
    int count = collection.Length; 
    int index = 0;

    while (index < count){
        Console.WriteLine(collection[index]);
        index++;
    }
    Console.WriteLine();
}

int[] arr = new int[10];

int index = 0;
while (index < arr.Length){
    arr[index] = new Random().Next(0, 10);
    index++;
}

PrintArray(arr);

int n = arr.Length;
int find = 3;

index = 0;
while (index < n){
    if (arr[index] == find){
        Console.WriteLine(index);
        break;
    }

    index++;
}