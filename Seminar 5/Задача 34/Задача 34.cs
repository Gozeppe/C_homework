/*Задача 34: Задайте массив заполненный случайными положительными трёхзначными числами. Напишите программу, которая покажет количество чётных чисел в массиве.

[345, 897, 568, 234] -> 2
*/
Console.WriteLine("Введите размер массива: ");
int size = Convert.ToInt32(Console.ReadLine());
int [] numbers = new int[size];
int count = 0;

FillArray(numbers);
PrintArray(numbers);




void FillArray(int[] numbers) // Метод заполняет массив случайными числами
{
    int lenght = numbers.Length;
    int index = 0;
    while (index < lenght)
    {
        numbers[index] = new Random().Next(99,1000);
        index++;
    }
}
void PrintArray(int[] cont)
{
    int count = cont.Length;
    int position = 0;
    while (position < count)
    {
        Console.WriteLine(cont[position]);
        position++;
    }
}



for (int i = 0; i < numbers.Length; i++)
if (numbers[i] % 2 == 0)
count++;

Console.WriteLine($"всего {numbers.Length} чисел, {count} из них чётные");