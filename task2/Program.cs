Console.WriteLine("Введите первое число");
int num1 = Convert.ToInt32(Console.ReadLine());

Console.WriteLine("Введите второе число");
int num2 = Convert.ToInt32(Console.ReadLine());

Console.WriteLine("Введите третье число");
int num3 = Convert.ToInt32(Console.ReadLine());

if(num1>=num2 && num1>=num3)
{
    Console.WriteLine($"{num1} больше второго и третьего числа или они равны");

}
else if (num2>num1 && num2>num3)
{
    Console.WriteLine($"{num2} больше первого и третьего чила");

}
else
{
    Console.WriteLine($"{num3} больше первого и второго числа");
}