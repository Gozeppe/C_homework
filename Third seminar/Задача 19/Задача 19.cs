/*
Задача 19
Напишите программу, которая принимает на вход пятизначное число и проверяет, является ли оно палиндромом.
14212 -> нет
12821 -> да
23432 -> да
*/

Console.WriteLine("Введите число: ");
string sum = Console.ReadLine();
int len = sum.Length;
if (len == 5)
{
    if (sum[0] == sum[4] && sum[1] == sum[3])
    {
        Console.WriteLine($"{sum} - Палиндром");
    }
    else
    {
        Console.WriteLine($"{sum} - НЕ палиндром");
    }
}
else
{
    Console.WriteLine($"ОШИБКА: {sum} - не является пятизначным");
}    