//Задача 19: Напишите программу, которая принимает на вход пятизначное число и проверяет, является ли оно палиндромом.

// 14212 -> нет
// 23432 -> да
// 12821 -> да



// Console.WriteLine ("Введите пятизначное число: ");
// int num = Convert.ToInt32 (Console. ReadLine()) ;
// string N = Convert.ToString (num);
// if (N[0] == N[4] && N[1] == N[3])
// {
// // Console.WriteLine ("Это число является палиндромом") ;

// }
// else
// {
// // Console.WriteLine ("Это число не является палиндромом") ;
// }


Console.WriteLine("Введите пятизначное числож: ");
int num1 = Convert.ToInt32(Console.ReadLine());
if(num1/10000 == num1%10 && (num1/1000)%10 == (num1/10)%10 )
{
    Console.WriteLine("Это число является палиндромом");

}
else
{
    Console.WriteLine("Это число не является палиндромом");
}

