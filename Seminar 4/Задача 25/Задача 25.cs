/*Задача 25: Напишите цикл, который принимает на вход два числа (A и B) и возводит число A в натуральную степень B.

3, 5 -> 243 (3⁵)

2, 4 -> 16
*/
try
{
Console.WriteLine ("Введите A: ");
int a = Convert.ToInt32 (Console.ReadLine ()); 


Console.WriteLine ("Введите B: ");
int b = Convert.ToInt32 (Console.ReadLine ());

int ToDegree = a;

for (int i = 1; i < b; i ++) 
{
  ToDegree = ToDegree*a;
}
 Console.WriteLine($"Число {a} в степени {b} равно {ToDegree}");
}
catch 
{
    Console.WriteLine("Вы ввели не число, введите число");
}
 
