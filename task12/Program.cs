// Задача 27: Напишите программу, которая принимает на вход число и выдаёт сумму цифр в числе.
// 452 -> 11
// 82 -> 10
// 9012 -> 12



// Console.WriteLine("Введите число: ");

// int[] num = Array.ConvertAll(Console.ReadLine().Split(), int.Parse);
// int numLen = num.Length;
// // int num = Convert.ToInt32(Console.ReadLine());
// // string N = Convert.ToString(num);
// // int Nlen = N.Length;
// // string[] nums = N.Split(new char{}, StringSplitOptions.RemoveEmptyEntries);
// // int[] Nlength = nums.Select(Int32.Parse).ToArray();
// foreach(var i in num)
// {
//     Console.Write($"Значения {i} ");
// }
// Console.WriteLine();



// int sum = 0;
// for(int j = 0; j < Nlength.Length; j++)
// {
//     sum = sum + Nlength[j];
   
// }
//  Console.WriteLine(sum);
//Попытался решить двумя вариантами, не получается, подскажите пожалуйста в чем ошибся



// void Sum()
// {
//     Console.WriteLine("Введите число: ");
//     int num = Convert.ToInt32(Console.ReadLine());

//     int count = 0;
//     int sum = 0;
//     for(int i = 0; num>0; i++)
//     {
//         count = num%10;
//         num = num/10;
//         sum = sum +count;
//         Console.Write($"{count} + ");
//     }
//     Console.WriteLine($"= {sum}");
// }

// Sum();


int SumPrint ( int num)
{
    int count = 0;
    int sum = 0;
    for(int i = 0; num>0; i++)
    {
        count = num%10;
        num = num/10;
        sum = sum +count;
        
    }
    
    return sum;
}
Console.Write("Сумма равна ");

Console.WriteLine(SumPrint(12345));