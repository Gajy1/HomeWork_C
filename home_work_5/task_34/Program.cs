Console.Clear();
void FillArray(int[] collection)
{
    int l = collection.Length;
    int i = 0;

    while (i < l)
    {
       collection[i] = new Random().Next(100, 1000);
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
  Console.WriteLine(summ);
}

int [] array = new int[12];
FillArray(array);
Console.Write($"[{string.Join(", ", array)}]");
Console.WriteLine();
Fr(array);