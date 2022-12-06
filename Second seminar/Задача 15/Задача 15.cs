/* Задача 15: Напишите программу, которая принимает на вход цифру, обозначающую день недели, и проверяет, является ли этот день выходным.

6 -> да
7 -> да
1 -> нет */

Console.WriteLine("Введите порядковый номер дня недели, от 1 до 7: ");
int DayOfWeek = Convert.ToInt32(Console.ReadLine());

if (DayOfWeek >= 1 && DayOfWeek <= 5){
    Console.WriteLine("Нет, это рабочий день");
}
 else if (DayOfWeek == 6 || DayOfWeek == 7){
    Console.WriteLine("Да, это выходной");
} 
else {
    Console.WriteLine("Введите, пожалуйста, число соответсвующее дню неделю, от 1 до 7");
}