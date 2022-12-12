Console.Clear();
Console.Write("Сколько элементов будет в массиве: ");
int n = Convert.ToInt32(Console.ReadLine());

void FillArray(int[] collection)
{
    int l = collection.Length;
    int i = 0;

    while (i < l)
    {
       collection[i] = Convert.ToInt32(Console.ReadLine());
       i++;
    }
}



int [] array = new int[n];
Console.WriteLine();

Console.WriteLine("Введите элементы массива:");

FillArray(array);
Console.Write($"[{string.Join(", ", array)}]");