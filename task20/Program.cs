// Задача 50: Напишите программу, которая на вход принимает позиции элемента в двумерном массиве,
//  и возвращает значение этого элемента или же указание, что такого элемента нет.
//  Например, задан массив:
// 1472
// 59 23
// 8 4 2 4
// 17 -> такого числа в массиве нет


int[,] matrix = new int[5, 5];
Console.WriteLine("Ведите число");
int num = Convert.ToInt32(Console.ReadLine());
ArrayMatrix(matrix);
Matrix(matrix);
FindNumbers(num);


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
            matrix[i, j] = new Random().Next(1, 10);
        }
    }
}


void FindNumbers(int value)
{
    int row = 0;
    int columns = 0;
    bool rowCol = false;
    for (int i = 0; i < matrix.GetLength(0); i++)
    {
        for (int j = 0; j < matrix.GetLength(1); j++)
        {
            if (matrix[i, j] == num)
            {
                row = i;
                columns = j;
                rowCol = true;

            }
        }

    }
    if(rowCol)
    {
        Console.WriteLine($"Это число есть в {row+1} строке {columns+1} колонке");
    }
    else
    {
        Console.WriteLine("Такого числа нет в массиве");
    }

}


// int row = ReadInt("Введите номер строки: ");
// int columns = ReadInt("Введите номер столбца: ");
// int[,] array = new int[5, 5];
// FillArray(array);
// Array(array);
// if (row < array.GetLength(0) && columns < array.GetLength(1))
// {
//     Console.WriteLine($"{array[row, columns]}");
// }
// else Console.WriteLine("Такого числа нет в массиве");


// void Array(int[,] array)
// {
//     for (int i = 0; i < array.GetLength(0); i++)
//     {
//         for (int j = 0; j < array.GetLength(1); j++)
//         {
//             Console.Write($" [ {array[i, j]} ]  ");
//         }
//         Console.WriteLine();
//     }
// }

// void FillArray(int[,] value)
// {
//     for (int i = 0; i < array.GetLength(0); i++)
//     {
//         for (int j = 0; j < array.GetLength(1); j++)
//         {
//             array[i, j] = new Random().Next(1, 10);
//         }
//     }
// }
// int ReadInt(string message)
// {
//     Console.Write(message);
//     return Convert.ToInt32(Console.ReadLine());
// }

