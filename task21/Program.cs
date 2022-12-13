// Задача 52: Задайте двумерный массив из целых чисел.
// Найдите среднее арифметическое элементов в каждом столбце.
// Например, задан массив:
// 1 47 2
// 59 2 3
// 8 4 2 4
// Среднее арифметическое каждого столбца: 4,6; 5,6; 3,6; 3.

int[,] array = new int[5, 5];
FillArray(array);
Array(array);
Average(array);



void Array(int[,] matrix)
{
    for (int i = 0; i < array.GetLength(0); i++)
    {
        for (int j = 0; j < array.GetLength(1); j++)
        {
            Console.Write($"  [ {array[i, j]} ]  ");
        }
        Console.WriteLine();
    }
}

void FillArray(int[,] value)
{
    for (int i = 0; i < array.GetLength(0); i++)
    {
        for (int j = 0; j < array.GetLength(1); j++)
        {
            array[i, j] = new Random().Next(1, 10);
        }
    }
}

void Average(int[,] sum)
{
    for (int i = 0; i < array.GetLength(0); i++)
    {
        int summa = 0;
        double average = 0; //среднее
        for (int j = 0; j < array.GetLength(1); j++)
        {
            summa = summa + array[j, i];
            average = summa/5.0;
        }
        Console.Write($"   {average}   ");
    }

}