// See https://aka.ms/new-console-template for more information
Console.Clear();
Console.WriteLine("Введите число");
int n = Convert.ToInt32(Console.ReadLine());
Console.WriteLine("Введите число");
int m = Convert.ToInt32(Console.ReadLine());
if (n > m)
Console.WriteLine($"max {n}, min {m}");
if (n < m)
Console.WriteLine($"max {m}, min {n}");
if (n == m)
Console.WriteLine($"Ошибка");