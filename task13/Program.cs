// Напишите программу, которая задаёт массив из 8 элементов и выводит их на экран.
// 1, 2, 5, 7, 19 -> [1, 2, 5, 7, 19]
// 6, 1, 33 -> I6, 1, 33]

int[] Array(int len)
{
    int[] array = new int[len];
    for(int i = 0; i<array.Length; i++)
    {
        array[i] = new Random().Next(0, 10);
    }
    return array;
}

int[] arr = Array(8);
void PrintArray(int[] array)
{
    for(int i = 0; i < array.Length; i++)
    {
        Console.Write($"{array[i]}, ");
    }
}
PrintArray(arr);