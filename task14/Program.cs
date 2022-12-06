// Задайте массив заполненный случайными положительными трёхзначными числами.
//  Напишите программу, которая покажет количество чётных чисел в массиве.
//  [345, 897, 568, 234] -> 2

int[] Array(int len)
{
    int[] array = new int[len];
    for(int i = 0; i < array.Length ; i++)
    {
        array[i] = new Random().Next(100, 1000);
    }
    return array;

}
int[] arr = Array(10);

void PrintArray(int[] array)
{
    for(int i = 0; i< array.Length; i++)
    {
        Console.Write($"{array[i]}, ");
    }
}

PrintArray(arr);


int sum = 0;
for(int i = 0; i < arr.Length; i++)
{
    if(arr[i]%2==0)
    {
        sum = sum +1;   
    }

}
Console.WriteLine();
Console.WriteLine($"количество четныйы чисел {sum}");