/* Задача 27: Напишите программу, которая принимает на вход число и выдаёт сумму цифр в числе.

452 -> 11

82 -> 10

9012 -> 12

*/

try{
Console.WriteLine("Введите число: ");
int num = Convert.ToInt32(Console.ReadLine());
Console.WriteLine($"Сумма цифр числа {num} равна: {NumberSum(num)}");
}
catch{
    Console.WriteLine("Вы ввели не число, введите число");
}
int NumberSum(int num)              
{
int sum = 0;
     while (num > 0)
     {
        sum = sum + num % 10;
        num /= 10;
     }
return sum;
}
