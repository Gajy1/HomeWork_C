Console.Clear();
Console.WriteLine("Введите трехзначное число");
int n = Convert.ToInt32(Console.ReadLine());
int x = n / 10;
int y = x % 10;
if(n < 100 || n > 999)Console.WriteLine("Вы ввели не трехзначное чилло");
else
Console.WriteLine(y);

