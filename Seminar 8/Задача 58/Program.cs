/* Задача 58: Задайте две матрицы. Напишите программу, которая будет находить произведение двух матриц.
Например, даны 2 матрицы:
2 4 | 3 4
3 2 | 3 3
Результирующая матрица будет:
18 20
15 18
*/

Console.WriteLine("введите количество строк у первой матрицы: ");
int rows = Convert.ToInt32(Console.ReadLine());
Console.WriteLine("введите количество столбцов у первой матрицы: ");
int columns = Convert.ToInt32(Console.ReadLine());
int[,] matr = new int[rows, columns];

Console.WriteLine("Введите количество строк у второй матрицы: ");
int rows2 = Convert.ToInt32(Console.ReadLine());
Console.WriteLine("Введите количество столбцов у второй матрицы: ");
int columns2 = Convert.ToInt32(Console.ReadLine());
int[,] matr2 = new int[rows2, columns2];
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
Console.WriteLine();


FillArrayRandomNumbers(matr);
FillArrayRandomNumbers(matr2);
PrintArray(matr);
Console.WriteLine();
PrintArray(matr2);

