﻿// Задача 54: Задайте двумерный массив. 
// Напишите программу, которая упорядочит по убыванию элементы каждой строки двумерного массива.

int[,] matrix = new int[5, 5];

ArrayMatrix(matrix);
Matrix(matrix);
NewMatrix(matrix);
Console.WriteLine();
Matrix(matrix);



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

void NewMatrix(int[,] matrix)
{
    for(int i = 0; i < matrix.GetLength(0); i++)
    {
        for(int j = 0; j < matrix.GetLength(1); j++)
        {
            for(int k = 0; k < matrix.GetLength(1)-1; k++)
            {
                if(matrix[i,k]< matrix[i,k+1])
                {
                    int temp = matrix[i,k+1];
                    matrix[i,k+1] = matrix[i,k];
                    matrix[i,k] = temp;
                }
            }
            
            
        }
    }
}