Console.Clear();
Console.WriteLine("Введите числа");
int[] array = Console.ReadLine().Split(" ").Select(x => int.Parse(x)).ToArray();
int summ = 0;
foreach(int element in array)
if(element > 0)
{
 summ++;
 
}

Console.WriteLine(summ);