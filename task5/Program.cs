// задача 10

int num = new Random().Next(100, 1000);
Console.WriteLine(num);
int count = num % 100 ;
int count2 = count/10;
Console.WriteLine("Вторая цифра этого числа: ");
Console.WriteLine(count2);
