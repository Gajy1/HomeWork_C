
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

void ReleaseMatrix(int[,] matrix)
{
   int n = 0;
   int i = 0;
   int j = 0;
   int count = 0;
   int printcount = 0;
   int s = matrix.GetLength(1);

   while(i < matrix.GetLength(0))
   {
     if(matrix[i, n] >= matrix[i, j])
      { 
        count++;
      }
      

      if(count == s)
      {
         Console.Write($"{matrix[i, n]} \t");
         printcount++;
         s = s -1;

      } 
        j++;

      if(j == matrix.GetLength(1))
      {
        n++;
        j = 0;
      } 

      if(n == matrix.GetLength(1) && printcount != matrix.GetLength(1))
      {
        n = 0;
        j = 0;
        
      }

      if(printcount == matrix.GetLength(1))
      {
        n = 0;
        j = 0;
        i++;
        s = matrix.GetLength(1);
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
ReleaseMatrix(matrix);
