Console.Clear();
Console.WriteLine("Введите чило");
int n = Convert.ToInt32(Console.ReadLine());
int i = 10;
int x = n % 10;
if(n < 100) Console.WriteLine("Третьего числа нет");
if(n >= 100 && n < 1000) Console.WriteLine(x);
else
while(n >= 1000){
   n = n / i;
   if(n < 1000)Console.WriteLine(n % 10);
}








