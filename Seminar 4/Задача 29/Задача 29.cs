/* Задача 29: Напишите программу, которая задаёт массив из 8 элементов и выводит их на экран.

1, 2, 5, 7, 19 -> [1, 2, 5, 7, 19]

6, 1, 33 -> [6, 1, 33]
*/

try 
{
    Console.WriteLine("Введите массив из 8 чисел: ");
    EnterArray();
}
catch
{
  Console.WriteLine("Ошибка: Надо было вводить массив цифрами!");
}
void EnterArray()
{
    int[] array = new int[8];
    for (int i = 0; i < array.Length; i++)
    {
        array[i] = Convert.ToInt32(Console.ReadLine());
    }
    Console.Write("Вы ввели массив: [");
    Console.Write(String.Join(", ", array));
    Console.Write("]");
}