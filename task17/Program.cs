// Пользователь вводит с клавиатуры М чисел.
// Посчитайте, сколько чисел больше 0 ввёл пользователь.
// 0, 7, 8, -2, -2 -> 2
// -1, -7, 567, 89, 223-> 3



// void Array(int[] n)
// {
   
//     int result = 0;
//     for (int i = 0; i < n.Length; i++)
//     {
//         if (n[i] > 0)
//         {
//             result = result + 1;
//         }
//         else
//         {
//             result = result + 0;
//         }
//     }
//     Console.WriteLine($"Всего {result} положительных чисел");
// }

//  Console.WriteLine("Введите числа через запятую");
//     string s = Convert.ToString(Console.ReadLine());
//     string[] nums = s.Split(new char[] { ',', ' ' }, StringSplitOptions.RemoveEmptyEntries);
//     int[] n = nums.Select(Int32.Parse).ToArray();
// Array(n);

Console.WriteLine("Сколько чисел будете вводить?");
int el = int.Parse(Console.ReadLine());
int[] array = new int[el];
int count =0;
for(int i = 0; i < array.Length; i++)
{
    array[i] = int.Parse(Console.ReadLine());
    if(array[i]>0)
    {
        count = count + 1;
    }
    else count=0;
}

Console.WriteLine($"{count} цифр больше нуля");
