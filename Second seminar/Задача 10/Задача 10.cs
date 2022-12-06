/* Задача 10: Напишите программу, которая принимает на вход трёхзначное число и на выходе показывает вторую цифру этого числа.

456 -> 5
782 -> 8
918 -> 1 */

Console.WriteLine("Введите трёхзначное число: ");
int threeNum = Convert.ToInt32(Console.ReadLine());
string threeNumString = Convert.ToString(threeNum);
if (threeNumString.Length == 3){
Console.WriteLine("Вторая цифра этого числа " + threeNumString[1]);
} else {
    Console.WriteLine("Вы ввели не трёхзначное число");
}