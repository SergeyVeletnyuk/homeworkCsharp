//задача 15
int a = Convert.ToInt32(Console.ReadLine());
Console.WriteLine(a);
if (a == 6)
{

    Console.WriteLine("Это суббота, выходной день");
}
else if (a == 7)
{
    Console.WriteLine("Это воскресенье, выходной день");
}
else if (a < 6 )
{
    Console.WriteLine("Рабочий день");
}
else
{
    Console.WriteLine("Это уже не дни недели, их всего 7");
}