Console.Clear();
Console.WriteLine("Введите число");
int n = Convert.ToInt32(Console.ReadLine());
Console.WriteLine("Введите число");
int m = Convert.ToInt32(Console.ReadLine());
Console.WriteLine("Введите число");
int d = Convert.ToInt32(Console.ReadLine());
int max = 0;
if(n > m)
max = n;
else
max = m;
if(max > d)
Console.WriteLine($"Максимальное число: {max}");
else
Console.WriteLine($"Максимальное число: {d}");








