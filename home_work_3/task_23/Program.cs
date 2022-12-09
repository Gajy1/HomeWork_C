Console.Clear();
Console.WriteLine("Введите число");
int N =  Convert.ToInt32(Console.ReadLine());
int i = 1;
int result = 0;
for( i = 1; i < N + 1; i++) {
    result = i*i*i;
    Console.Write($"{result} ");
}

