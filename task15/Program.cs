// Задайте одномерный массив, заполненный случайными числами. Найдите сумму элементов, стоящих на нечётных позициях.

int[] Array(int len)
{
    int[] array = new int[len];
    for(int i = 0; i < array.Length; i++)
    {
        array[i] = new Random().Next(0, 20);
    }
    return array;
}

int[] arr = Array(10);

void PrintArray(int[] array)
{
    for(int i = 0; i < array.Length; i++)
    {
        Console.Write($"{array[i]} ");
    }
}
PrintArray(arr);
int sum = 0;
for(int i = 0; i < arr.Length; i++)
{
    if(i%2 != 0)
    {
        sum = sum + arr[i];
    
    }
    
    
}
Console.WriteLine();
Console.WriteLine($"сумма цифр на нечетных позициях равна {sum}");