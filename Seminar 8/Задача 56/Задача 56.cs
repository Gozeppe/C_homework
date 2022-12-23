/* Задача 56: Задайте прямоугольный двумерный массив. Напишите программу, которая будет находить строку с наименьшей суммой элементов.

Например, задан массив:

1 4 7 2

5 9 2 3

8 4 2 4

5 2 6 7

Программа считает сумму элементов в каждой строке и выдаёт номер строки с наименьшей суммой элементов: 1 строка
*/

Console.WriteLine("введите количество строк: ");
int rows = Convert.ToInt32(Console.ReadLine());
Console.WriteLine("введите количество столбцов: ");
int columns = Convert.ToInt32(Console.ReadLine());
int[,] matr = new int[rows, columns];
int sumMin = Int32.MaxValue;
int indexLine = 0;

void PrintArray(int[,] array)
{
    for (int i = 0; i < array.GetLength(0); i++)
    {
        for (int j = 0; j < array.GetLength(1); j++)
        {
            Console.Write(array[i, j] + " ");
        }
        Console.WriteLine("");
    }
}
void FillArrayRandomMatr(int[,] array)
{
    for (int i = 0; i < array.GetLength(0); i++)
    {
        for (int j = 0; j < array.GetLength(1); j++)
        {
            array[i, j] = new Random().Next(0, 10);
        }
    }
}
Console.WriteLine();


FillArrayRandomMatr(matr);
PrintArray(matr);

for (int i = 0; i < matr.GetLength(0); i++)
{
    int sum = 0;
    for (int j = 0; j < matr.GetLength(1); j++)
    {
        sum = sum + matr[i, j];        
    }
    if (sum < sumMin)
    {
        sumMin = sum;
        indexLine++;
    }
}

Console.WriteLine("строка с наименьшей суммой елементов под номером: " + (indexLine) + ", с суммой елементов равной: " + (sumMin));