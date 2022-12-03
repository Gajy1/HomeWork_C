Console.Clear();
Console.WriteLine("Введите цыфру от 1 до 7");
int n = Convert.ToInt32(Console.ReadLine());
if(n == 6 || n == 7) Console.WriteLine("yes");
if(n == 1 || n == 2 || n == 3 || n == 4 || n == 5) Console.WriteLine("No");
if(n > 7 || n < 1) Console.WriteLine("Введите цыфру от 1 до 7");
