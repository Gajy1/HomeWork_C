Console.Clear();
Console.WriteLine("Введите пятизначное число");
string s = Console.ReadLine();
int a = s.Length;
if(a != 5)
Console.WriteLine("Вы ввели не пятизначное число");
if(s[0] == s[4] && s[1] == s[3])
Console.WriteLine("Yes");
if(a == 5 && s[0] != s[4] && s[1] != s[3])
Console.WriteLine("No");

