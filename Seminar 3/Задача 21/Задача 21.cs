/* Напишите программу, которая принимает на вход координаты двух точек и находит расстояние между ними в 3D пространстве.

A (3,6,8); B (2,1,-7), -> 15.84

A (7,-5, 0); B (1,-1,9) -> 11.53
*/

try{
Console.WriteLine("Введите координаты точки A по оси X: ");
int ax = Convert.ToInt32(Console.ReadLine());
Console.WriteLine("Введите координаты точки A по оси Y: ");
int ay = Convert.ToInt32(Console.ReadLine());
Console.WriteLine("Введите координаты точки A по оси Z: ");
int az = Convert.ToInt32(Console.ReadLine());


Console.WriteLine("Введите координаты точки B по оси X: ");
int bx = Convert.ToInt32(Console.ReadLine());
Console.WriteLine("Введите координаты точки B по оси Y: ");
int by = Convert.ToInt32(Console.ReadLine());
Console.WriteLine("Введите координаты точки B по оси Z: ");
int bz = Convert.ToInt32(Console.ReadLine());

var result = Math.Sqrt(Math.Pow((bx - ax), 2) + Math.Pow((by - ay), 2) + Math.Pow((bz - az), 2));
Console.WriteLine(result);
}

catch {
    Console.WriteLine("Введите корректные координаты точек");
}
