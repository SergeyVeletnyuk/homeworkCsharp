Console.WriteLine("Введите первое число");
int num1 = Convert.ToInt32(Console.ReadLine());

Console.WriteLine("Введите второе число");
int num2 = Convert.ToInt32(Console.ReadLine());

if (num1>num2)
{
    Console.WriteLine($"число {num1} больше чем чиcло {num2}");
}
else
{
    Console.WriteLine($"{num2} больше чем число {num1}");
}
