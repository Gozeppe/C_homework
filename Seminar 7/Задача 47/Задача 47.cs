/* Задача 47. Задайте двумерный массив размером m×n, заполненный случайными вещественными числами.

m = 3, n = 4.

0,5 7 -2 -0,2

1 -3,3 8 -9,9

8 7,8 -7,1 9
*/


void PrintArray(int[,] matr)
{
 for (int m = 0; m < matr.GetLength(0); m++)
 {
 for (int n = 0; n < matr.GetLength(1); n++)
 {
 Console.Write($"{matr[m, n]} ");
 }
 Console.WriteLine();
 }
}
void FillArray(int[,] matr)
{
 for (int m = 0; m < matr.GetLength(0); m++)
 {
 for (int n = 0; n < matr.GetLength(1); n++)
 {
 matr[m,n] = new Random().Next(1,10);//[1; 10)
 }
 }
}
int[,] matrix = new int[5, 5];
FillArray(matrix);
Console.WriteLine();
PrintArray(matrix);
