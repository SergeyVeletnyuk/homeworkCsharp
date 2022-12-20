// Задайте значения М и N. Напишите программу, которая найдёт сумму натуральных элементов в промежутке от М до N.
// M = 1: N = 15 -> 120
// M = 4; N = 8. -> 30


Console.WriteLine("введите число M: ");
int m = Convert.ToInt32(Console.ReadLine());

Console.WriteLine("Введите число N: ");
int n = Convert.ToInt32(Console.ReadLine());

int Numbers(int m, int n)
{
    if(m==n) return n;
    else
    {
       return n + Numbers(m,n-1);
        
    }
}

if(m > n)
{
     Numbers(n,m);
     Console.WriteLine(Numbers(n,m));
}
else
{
    Numbers(m,n);
    Console.WriteLine(Numbers(m,n));
}



