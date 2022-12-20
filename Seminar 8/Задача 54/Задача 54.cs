/* Задача 54: Задайте двумерный массив. Напишите программу, которая упорядочит по убыванию элементы каждой строки двумерного массива.
Например, задан массив:
1 4 7 2
5 9 2 3
8 4 2 4
В итоге получается вот такой массив:
7 4 2 1
9 5 3 2
8 4 4 2
*/

Console.WriteLine("введите количество строк: ");
int rows = Convert.ToInt32(Console.ReadLine());
Console.WriteLine("введите количество столбцов: ");
int columns = Convert.ToInt32(Console.ReadLine());
int[,] matr = new int[rows, columns];
FillArrayRandomNumbers(matr);
Console.WriteLine();
Console.WriteLine("Задан массив: ");
PrintArray(matr);

for (int i = 0; i < matr.GetLength(0); i++)
{
    for (int j = 0; j < matr.GetLength(1) - 1; j++)
    {
        for (int s = 0; s < matr.GetLength(1) - 1; s++)
        {
            if (matr[i, s] < matr[i, s + 1]) 
            {
                int temp = 0;
                temp = matr[i, s];
                matr[i, s] = matr[i, s + 1];
                matr[i, s + 1] = temp;
            }
        }
    }
}
Console.WriteLine();
Console.WriteLine("Получившийся массив: ");
PrintArray(matr);

void FillArrayRandomNumbers(int[,] array)
{
    for (int i = 0; i < array.GetLength(0); i++)
    {
        for (int j = 0; j < array.GetLength(1); j++)
        {
            array[i, j] = new Random().Next(0, 10);
        }
    }
}

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