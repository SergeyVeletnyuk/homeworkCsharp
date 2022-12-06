// Задайте массив вещественных чисел.
// Найдите разницу между максимальным и минимальным элементов массива.

int[] Array(int len)
{
    int[] array = new int[len];
    for(int i = 0; i<array.Length; i++)
    {
        array[i] = new Random().Next(1, 55);
    }
    return array;
}

int[] arr = Array(10);

void PrintArray(int[] array)
{
    for(int i = 0; i < array.Length; i++)
    {
        Console.Write($"{array[i]}, ");
    }
}

PrintArray(arr);

int Max = arr[0];
int Min = arr[0];
for(int i = 0; i < arr.Length; i++)
{
    if(arr[i]>Max)
    {
        Max = arr[i];
       
    }
    else if(arr[i]< Min)
    {
        Min = arr[i];
        
    }
}
Console.WriteLine();
 Console.WriteLine(Max);
 Console.WriteLine(Min);
 Console.WriteLine($"разность максимального и минимального числа = {Max-Min}");