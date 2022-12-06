// Задача 25; Напишите цикл, который принимает на вход два числа (А и В) и возводит число А в натуральную степень В.
// 3, 5 -> 243 (35)
// 2,4 -> 16


// void Pow()
// {
//     Console.WriteLine("Введите первое число: ");
// int num1 = Convert.ToInt32(Console.ReadLine());

// Console.WriteLine("Введите второе число: ");
// int num2 = Convert.ToInt32(Console.ReadLine());

    
//     int result = (int)Math.Pow(num1, num2);
//     Console.WriteLine(result);
// }   


// Pow();

// int Pow(int num1, int num2)
// {
//     int result = (int)Math.Pow(num1, num2);
//     return result;

// }

// Console.WriteLine(Pow(2, 5));


    Console.WriteLine("Введите первое число: ");
int num1 = Convert.ToInt32(Console.ReadLine());

Console.WriteLine("Введите второе число: ");
int num2 = Convert.ToInt32(Console.ReadLine());

int i =0;
int sum = 1;
while(i<num2)
{
    sum = sum * num1;
    i++;
}   
Console.WriteLine(sum);
