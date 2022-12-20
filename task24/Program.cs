// Задайте две матрицы. Напишите программу, которая будет находить произведение двух матриц.

int[,] matrix = new int[3, 3];
int[,] matrix1 = new int[3,3];
ArrayMatrix(matrix);
Matrix(matrix);
Console.WriteLine();
ArrayMatrix1(matrix1);
Matrix(matrix1);
Console.WriteLine("Результат перемножения");
int[,] newMatrix = new int[3,3];
NewMatrix(matrix,matrix1);
Matrix(newMatrix);




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


void ArrayMatrix1(int[,] value)
{
    for (int i = 0; i < matrix1.GetLength(0); i++)
    {
        for (int j = 0; j < matrix1.GetLength(1); j++)
        {
            matrix1[i, j] = new Random().Next(1, 5);
        }
    }
}

void NewMatrix(int[,] matrix, int[,] matrix1)
{
    for(int i = 0; i < newMatrix.GetLength(0); i++)
    {
        int sum =0;
        for(int j = 0; j < newMatrix.GetLength(1); j++)
        {
            sum = matrix[i,j] * matrix1[i,j];
            newMatrix[i,j] = sum;

        }
    }
}
