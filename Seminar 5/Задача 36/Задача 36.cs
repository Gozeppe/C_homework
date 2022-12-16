/* Задача 36: Задайте одномерный массив, заполненный случайными числами. Найдите сумму элементов, стоящих на нечётных позициях.

[3, 7, 23, 12] -> 19

[-4, -6, 89, 6] -> 0
*/

Console.WriteLine("Введите размер массива: ");
int size = Convert.ToInt32(Console.ReadLine());
int [] numbers = new int[size];
int sum = 0;


FillArray(numbers);
PrintArray(numbers);
for (int i = 0; i < numbers.Length; i+=2){
    sum = sum + numbers[i];
}
Console.WriteLine($"всего {numbers.Length} чисел, сумма элементов на нечётных позициях = {sum}");

void FillArray(int[] numbers) 
{
    int lenght = numbers.Length;
    int index = 0;
    while (index < lenght)
    {
        numbers[index] = new Random().Next(1,99);
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
