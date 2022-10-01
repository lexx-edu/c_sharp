int a = 1;
int b = 2;
int c = 6;
int d = 8;
int e = 4;

int max_weight = a;

if (b > max_weight) max_weight = b;
if (c > max_weight) max_weight = c;
if (d > max_weight) max_weight = d;
if (e > max_weight) max_weight = e;

Console.WriteLine(max_weight);