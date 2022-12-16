/* Задача 38: Задайте массив вещественных чисел. Найдите разницу между максимальным и минимальным элементов массива.

[3 7 22 2 78] -> 76
*/
Console.WriteLine("Введите размер массива: ");
int size = Convert.ToInt32(Console.ReadLine());
int [] numbers = new int[size];

double min = Int32.MaxValue;
double max = Int32.MinValue;

FillArray(numbers);
PrintArray(numbers);

void FillArray(int[] numbers) // Метод заполняет массив случайными числами
{
    int lenght = numbers.Length;
    int index = 0;
    while (index < lenght)
    {
        numbers[index] = new Random().Next(1, 100);
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
{
    if (numbers[i] > max)
        {
            max = numbers[i];
        }
    if (numbers[i] < min)
        {
            min = numbers[i];
        }
}
Console.WriteLine($"всего {numbers.Length} чисел. Максимальное значение = {max}, минимальное значение = {min}");
Console.WriteLine($"Разница между максимальным и минимальным значением = {max - min}");