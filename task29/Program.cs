// Напишите программу вычисления функции Аккермана с помощью рекурсии. Даны два неотрицательных числа m и п.

Console.WriteLine("введите число M: ");
int n = Convert.ToInt32(Console.ReadLine());

Console.WriteLine("Введите число N: ");
int m = Convert.ToInt32(Console.ReadLine());

int Akkerman(int n, int m)
{
    if(n==0) return m+1;
    if(m==0) return  Akkerman(n-1,1);
    if(m !=0 && n !=0) return Akkerman(n-1,Akkerman(n,m-1));
    return m;
}
Console.WriteLine(Akkerman(n,m));