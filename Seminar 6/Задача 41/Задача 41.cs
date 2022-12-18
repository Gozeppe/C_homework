/* Задача 41: Пользователь вводит с клавиатуры M чисел. Посчитайте, сколько чисел больше 0 ввёл пользователь.

0, 7, 8, -2, -2 -> 2

1, -7, 567, 89, 223-> 3
*/

Console.WriteLine("Введите количество чисел: ");
int m = Convert.ToInt32(Console.ReadLine());
int[] ManyNumbers = new int[m];

void InputNumbers(int m)
{
for (int i = 0; i < m; i++)
  {
    Console.Write($"Введите {i+1} число: ");
    ManyNumbers[i] = Convert.ToInt32(Console.ReadLine());
  }
}


int MoreThanZero(int[] ManyNumbers)
{
  int count = 0;
  for (int i = 0; i < ManyNumbers.Length; i++)
  {
    if(ManyNumbers[i] > 0 ) 
    {
    count += 1; 
    }
  }
  return count;
}

InputNumbers(m);

Console.WriteLine($"Введено чисел больше 0: {MoreThanZero(ManyNumbers)} ");

