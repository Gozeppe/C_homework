/*
Задача 19
Напишите программу, которая принимает на вход пятизначное число и проверяет, является ли оно палиндромом.
14212 -> нет
12821 -> да
23432 -> да
*/
try{
Console.WriteLine("Введите пятизначное число: ");
int poly = Convert.ToInt32(Console.ReadLine());
Polycheck(poly);
}
catch {
    Console.WriteLine("Вводить нужно число. ");
}
void Polycheck(int poly){
    int temp = poly;
    int result = 0;
if (99999 > poly && poly > 9999 )
{
    while (temp > 0){
        result *= 10; 
        result += temp % 10;
        temp /= 10;
    }
 if (poly == result){
    Console.WriteLine("Да, это палидром");
} 
else
{
    Console.WriteLine("Нет, это не палидром");
}
}
else{
  Console.WriteLine("Вводить нужно пятизначное число");
}
}

