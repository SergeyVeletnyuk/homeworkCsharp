// Сформируйте трёхмерный массив из неповторяющихся двузначных чисел.
//  Напишите программу, которая будет построчно выводить массив, добавляя индексы каждого элемента.


int[,,] matrix = new int[3,3,3];
ArrayMatrix(matrix);
Matrix(matrix);


void Matrix(int[,,] matrix)
{
    for (int i = 0; i < matrix.GetLength(0); i++)
    {
        for (int j = 0; j < matrix.GetLength(1); j++)
        {
            
            for(int k = 0; k < matrix.GetLength(2); k++)
            {
            Console.Write($"({i}{j}{k})->{matrix[i,j,k]}  ");
            }
        }
        Console.WriteLine();
    }
}

void ArrayMatrix(int[,,] value)
{
    for (int i = 0; i < matrix.GetLength(0); i++)
    {
        for (int j = 0; j < matrix.GetLength(1); j++)
        {
            for(int k =0; k < matrix.GetLength(2); k++)
            {
                matrix[i,j,k] = new Random().Next(10, 100);
                
            }
            
        }
    }
}

// void Matrix2(int[,,] matrix)
// {
//     for(int)
// }