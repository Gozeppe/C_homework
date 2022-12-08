// Задача 8
/*
Напишите программу, которая на вход принимает число (N), а на выходе показывает все чётные числа от 1 до N.
5 -> 2, 4
8 -> 2, 4, 6, 8 
*/
Console.WriteLine("Введите число ");
int NumberA = Convert.ToInt32(Console.ReadLine());

int index = 0;
while(index<NumberA)
{
if (index % 2==1) 
{
    Console.WriteLine(index+1);
}
    index++;
}