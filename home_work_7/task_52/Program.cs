
void InputMatrix(int[,] matrix)
{
    for (int i = 0; i < matrix.GetLength(0); i++)
    {
        for (int j = 0; j < matrix.GetLength(1); j++)
        {
            matrix[i, j] = new Random().Next(-10, 11); // [-10, 10]
            Console.Write($"{matrix[i, j]} \t");
        }
        Console.WriteLine();
    }
}

void InputSumm(int[,] matrix)
{
    double n = 0;
    int x = 1; 
    for (int j = 0; j < matrix.GetLength(0); j++)
    {
        for (int i = 0; i < matrix.GetLength(1); i++)
        {
           x = x + i; 
           n = n + matrix[i, j];
           i++;
           n = n + matrix[i, j];
            
        }
        Console.Write($"{n/4}; ");
        n = 0;
    }
        Console.WriteLine();
    
}



Console.Clear();

int[] size = {4,4};
int[,] matrix = new int[size[0], size[1]];
InputMatrix(matrix);
Console.WriteLine();
InputSumm(matrix);