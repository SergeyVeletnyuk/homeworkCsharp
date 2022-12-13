// Задача 43. Напишите программу, которая найдёт точку пересечения двух прямых,
//  заданных уравнениями у = k1 * × + b1, y = k2 * x + b2; значения b1, k1, b2 и k2 задаются пользователем.
//  b1 = 2, k1 = 5, b2 = 4, k2 = 9 -> (-0,5; -0,5)


// y = k1*X+b1;    
// y = k2*x+b2;
//k1*x+b1=k2*x+b2
//(k1-k2)x=-b1+b2

void Intersection(double b1, double k1, double b2, double k2)
{
double x = (-b1 + b2) / (k1 - k2);
double y = k1 * x + b1;
 
 
Console.WriteLine($"Пересечение в точке: ({x};{y})");
}

Console.WriteLine("Введите b1: ");
double b1 = Convert.ToDouble(Console.ReadLine());
Console.WriteLine("Введите k1: ");
double k1 = Convert.ToDouble(Console.ReadLine());
Console.WriteLine("Введите b2: ");
double b2 = Convert.ToDouble(Console.ReadLine());
Console.WriteLine("Введите k2: ");
double k2 = Convert.ToDouble(Console.ReadLine());


Intersection(b1,k1,b2,k2);