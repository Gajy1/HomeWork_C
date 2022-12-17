Console.Clear();
double[] array = new double[16];
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
    
    double summ = Math.Abs(array[15] - array[0]);
    double s = Math.Round(summ, 2);
  Console.WriteLine(s);
}


    
  
  

FillArray(array);
Console.Write($"[{string.Join(". ", array)}]");
Console.WriteLine();
Fr(array);

