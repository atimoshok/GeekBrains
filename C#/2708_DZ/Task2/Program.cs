// Напишите программу, которая принимает на вход координаты двух точек и находит расстояние между ними в 3D пространстве.

// A (3,6,8); B (2,1,-7), -> 15.84
// A (7,-5, 0); B (1,-1,9) -> 11.53

Console.WriteLine("Введите координаты первой точки (х, у, z)");
Console.Write("x = ");
int x1 = Convert.ToInt32(Console.ReadLine());
Console.Write("y = ");
int y1 = Convert.ToInt32(Console.ReadLine());
Console.Write("z = ");
int z1 = Convert.ToInt32(Console.ReadLine());

Console.WriteLine("Введите координаты второй точки (х, у, z)");
Console.Write("x = ");
int x2 = Convert.ToInt32(Console.ReadLine());
Console.Write("y = ");
int y2 = Convert.ToInt32(Console.ReadLine());
Console.Write("z = ");
int z2 = Convert.ToInt32(Console.ReadLine());

double d = Math.Sqrt(Math.Pow(x2 - x1, 2) + Math.Pow(y2 - y1, 2) + Math.Pow(z2 - z1, 2));
Console.WriteLine($"Расстояние между точками = {Math.Round(d, 2)}");