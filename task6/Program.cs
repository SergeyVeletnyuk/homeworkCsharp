// задача 13

int a = new Random().Next(1, 100000);
Console.WriteLine(a);
if (a>99 && a<1000)
{
    int b = a % 10;
    Console.WriteLine(b);
}
else if (a>1000 && a < 10000)
{
    int count = a%100;
    int b1 = count/10;
    Console.WriteLine(b1);
}
else if (a>10000 && a<100000)
{
    int count2 = a%1000;
    int b2 = count2/100;
    Console.WriteLine(b2);
}

// int a = new Random().Next(1, 10000);
// Console.WriteLine(a);
// string a1 = Convert.ToString(a);
// if (a1.Length > 2)
// {
//     Console.WriteLine("третья цифра: " + a1[2]);
// }
// else
// {
//     Console.WriteLine("Третьей цифры нет");
// }