// Задайте двумерный массив размером mхn,
// заполненный случайными вещественными числами.
// m = 3, n = 4.
// 0,5 7 -2 - 0,2
// 1-3,3 8 - 9,9
// 8 7,8 -7,1 9

double [,] matrix = new double[3, 4];

void PrintMatrix(double[,] matrix)
{
    for(int i = 0; i < matrix.GetLength(0); i++)
    {
        for(int j = 0; j < matrix.GetLength(1); j++)
        {
            Console.Write($"    {matrix[i, j]}    ");
        }
        Console.WriteLine();
    }
}

void NewMatrix(double[,] matrix)
{
    
    for(int i = 0; i < matrix.GetLength(0); i++)
    {
        for(int j = 0; j < matrix.GetLength(1); j++)
        {
            matrix[i, j] = new Random().Next(-10, 10)/10.0;

            
        }
    }
}

PrintMatrix(matrix);
NewMatrix(matrix);
Console.WriteLine();
PrintMatrix(matrix);