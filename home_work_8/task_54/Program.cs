
void InputMatrix(int[,] matrix)
{
    for (int i = 0; i < matrix.GetLength(0); i++)
    {
        for (int j = 0; j < matrix.GetLength(1); j++)
            matrix[i, j] = new Random().Next(0, 11); // [-10, 10]
    }
}


void PrintMatrix(int[,] matrix)
{
    for (int i = 0; i < matrix.GetLength(0); i++)
    {
        for (int j = 0; j < matrix.GetLength(1); j++)
            Console.Write($"{matrix[i, j]} \t");
        Console.WriteLine();
    }
}

void ReplaceElement(int[,] matrix)
{
   int i = 0;
   int j = 0;
   int n = 0;
   int s = matrix.GetLength(1);
   int count = 0;
   int printcount = 0;

   while(i < matrix.GetLength(0))
   {
     if(matrix[i, n] >= matrix[i, j])
     {
      count++;
     }
     j++;
     if(count == s)
     {
       Console.Write($"{matrix[i, n]} ");
       printcount++;
       s = s - 1;
       count = 0;
       j = 0;
       n++;
     }
     if(n == matrix.GetLength(1))
       n = 0;
       
     if(j == matrix.GetLength(1)  && count != s)
     {
      n++;
      j = 0;
      count = 0;
     }
     if(printcount == matrix.GetLength(1))
     {
      i++;
      n = 0;
      j = 0;
      s = matrix.GetLength(1);
      count = 0;
      printcount = 0;
      Console.WriteLine();
     }
   }
   
}


Console.Clear();
Console.Write("Введите размер матрицы: ");
int[] size = Console.ReadLine().Split(" ").Select(x => int.Parse(x)).ToArray();
// size[0] - row
// size[1] - column
int[,] matrix = new int[size[0], size[1]];
Console.WriteLine("Начальный массив:");
InputMatrix(matrix);
PrintMatrix(matrix);
Console.WriteLine("Конечный массив:");
ReplaceElement(matrix);


