Console.Clear();
Console.WriteLine("Введите число");
int n = Convert.ToInt32(Console.ReadLine());
int m = 1;
int i = 0;
while(i <= n)
{
  if(m % 2 == 0)
  Console.Write($" {m}");
  i = i + 1; 
  m = m + 1; 

}
