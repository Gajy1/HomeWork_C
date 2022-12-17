
Console.Clear();
int[] array = new int[5];

void FillArray(int[] array)
{
    int l = array.Length;
    int i = 0;

    while (i < l)
    {
       array[i] = new Random().Next(1, 10);
       i++;
    }
}   

void Fr(int[] array)
{
    
    int summ =array[0];
  for(int i = 1; i < array.Length; i++)
  {
    if(i % 2 != 0)
    summ = summ + array[i];
  }
  Console.WriteLine();
  Console.WriteLine($"Сумма элементов нечетных позиции: {summ}");
}


FillArray(array);
Console.Write($"[{string.Join(", ", array)}]");
Console.WriteLine();
Fr(array);
