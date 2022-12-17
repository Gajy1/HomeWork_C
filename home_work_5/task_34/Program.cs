Console.Clear();
void FillArray(int[] array)
{
    int l = array.Length;
    int i = 0;

    while (i < l)
    {
       array[i] = new Random().Next(100, 1000);
       i++;
    }
}

void Fr(int[] array)
{
    int summ = 0;
  for(int i = 0; i < array.Length; i++)
  {
    if(array[i] % 2 == 0)
    summ++;
  }
   Console.WriteLine();
   Console.WriteLine($"Количество четных чисел: {summ}");
}

int [] array = new int[12];
FillArray(array);
Console.Write($"[{string.Join(", ", array)}]");
Console.WriteLine();
Fr(array);