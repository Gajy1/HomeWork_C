Console.Clear();
double[] array = new double[11];
void FillArray(double[] array)
{
    int l = array.Length;
    int i = 0;
    double n = 0;
    int m = new Random().Next(-10, 10);
    while (i < l)
    {
        m = new Random().Next(-10, 10);
        n = new Random().NextDouble()* 10;
       array[i] = Math.Round(m*n, 2);
       i++;
    }
}   

void Fr(double[] array)
{
  double  min = array[0];
  double max = 0;
    for(int i = 0; i < array.Length; i++)
    {
      if(array[i] > max)
      max = array[i];
      if(array[i] < min)
      min = array[i];
    }
    double summ = Math.Abs(min - max);
    double s = Math.Round(summ, 2);
    Console.Write($"max: {max} min:{min}");
    Console.WriteLine();
    Console.WriteLine($"Разница: {s}");
}
  


    
  
  

FillArray(array);
Console.Write($"[{string.Join(". ", array)}]");
Console.WriteLine();
Fr(array);

