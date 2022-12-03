
Console.WriteLine("Введите трехзначное число");
string? s = Console.ReadLine();
int m = s.Length;
if(m != 3)
Console.WriteLine("Вы ввели не трехзначное чилло");
else Console.WriteLine(Convert.ToInt32(s[1].ToString()));

