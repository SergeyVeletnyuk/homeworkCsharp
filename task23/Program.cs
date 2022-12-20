// Задайте прямоугольный двумерный массив.
//  Напишите программу, которая будет находить строку с наименьшей суммой элементов.

int[,] matrix = new int[3, 5];

ArrayMatrix(matrix);
Matrix(matrix);
FindLine(matrix);



void Matrix(int[,] matrix)
{
    for (int i = 0; i < matrix.GetLength(0); i++)
    {
        for (int j = 0; j < matrix.GetLength(1); j++)
        {
            Console.Write($"  {matrix[i, j]}  ");
        }
        Console.WriteLine();
    }
}

void ArrayMatrix(int[,] value)
{
    for (int i = 0; i < matrix.GetLength(0); i++)
    {
        for (int j = 0; j < matrix.GetLength(1); j++)
        {
            matrix[i, j] = new Random().Next(1, 5);
        }
    }
}

void FindLine(int[,] line)
{
    int sum = 0;
    int idx = 0;
    
    for(int i =0; i <  matrix.GetLength(0); i++)
    {
        int temp = 0;
        for(int j = 0; j < matrix.GetLength(1); j++)
        {
            temp = temp + matrix[i,j];
        }
        if(temp>sum)
        {
            sum = temp;
            idx = i;
        }
    }
    Console.WriteLine($" в {idx+1} строке  сумма цифр больше чем в других = {sum}");
    
}