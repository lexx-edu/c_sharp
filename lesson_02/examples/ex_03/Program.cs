int max_function(int arg_1, int arg_2, int arg_3){
    int result = arg_1;
    if (arg_2 > result) result = arg_2;
    if (arg_3 > result) result = arg_3;

    return result;
}

int a1 = 15; 
int b1 = 21; 
int c1 = 39;
int a2 = 12; 
int b2 = 23; 
int c2 = 33;
int a3 = 13; 
int b3 = 23; 
int c3 = 33;

int result = max_function(max_function(a1, b1, c1),
                          max_function(a2, b2, c2),
                          max_function(a3, b3, c3));

Console.WriteLine(result); 