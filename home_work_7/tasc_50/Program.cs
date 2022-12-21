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

void InputElement(int[,] matrix)
{
    int[] pos = Console.ReadLine().Split(" ").Select(x => int.Parse(x)).ToArray();
    int i = pos[0] - 1;
    int j = pos[1] - 1;

    if(i < 6 && j < 6)
     Console.WriteLine(matrix[i, j]);       
    else
     Console.WriteLine("Такого элемента нет");  
            
} 

Console.Clear();

int[] size = {6,6};
int[,] matrix = new int[size[0], size[1]];
InputMatrix(matrix);
Console.WriteLine();
Console.Write("Введите позицию элемента: ");
InputElement(matrix);
