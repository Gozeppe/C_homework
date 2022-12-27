/* Задача 58: Задайте две матрицы. Напишите программу, которая будет находить произведение двух матриц.
Например, даны 2 матрицы:
2 4 | 3 4
3 2 | 3 3
Результирующая матрица будет:
18 20
15 18
*/

int InputInt(string output)
{
    Console.Write(output);
    return int.Parse(Console.ReadLine());
}

void FillArrayRandomNumbers(int[,] array)
{
    for (int i = 0; i < array.GetLength(0); i++)
    {
        for (int j = 0; j < array.GetLength(1); j++)
        {
            array[i, j] = new Random().Next(1, 5); 
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

int size = InputInt("Размер матриц: ");
int[,] matr = new int[size, size];
int[,] matr2 = new int[size, size];
FillArrayRandomNumbers(matr);
FillArrayRandomNumbers(matr2);
int[,] matr3 = new int[size, size];

for (int i = 0; i < size; i++)
{
    for (int j = 0; j < size; j++)
    {
        for (int k = 0; k < size; k++)
        {
            matr3[i, j] = matr3[i, j] + (matr[i, k] * matr2[k, j]);
        }
    }
}
Console.WriteLine("Матрица - 1");
PrintArray(matr);
Console.WriteLine();
Console.WriteLine("Матрица - 2");
PrintArray(matr2);
Console.WriteLine();
Console.WriteLine("Произведение матриц 1*2");
PrintArray(matr3);