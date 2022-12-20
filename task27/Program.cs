// Задайте значения М и N. Напишите программу, которая выведет все натуральные числа в промежутке от М до N.
// M = 1; N = 5. -> "1, 2, 3, 4, 5"
// M = 4; N = 8. -> "4, 6, 7,8"

Console.WriteLine("введите число M: ");
int m = Convert.ToInt32(Console.ReadLine());

Console.WriteLine("Введите число N: ");
int n = Convert.ToInt32(Console.ReadLine());

void Numbers(int m, int n)
{
    if(m==n) Console.Write($" {m} ");
    else
    {
        Numbers(m, n-1);
        Console.Write($" {n} ");
    }
}
if (m > n)
{
    Numbers(n,m);

}
else
{
    Numbers(m,n);
}