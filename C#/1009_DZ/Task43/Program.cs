// Напишите программу, которая найдёт точку пересечения двух прямых, заданных уравнениями
//y = k1 * x + b1
//y = k2 * x + b2;

//значения b1, k1, b2 и k2 задаются пользователем.

// b1 = 2, k1 = 5, b2 = 4, k2 = 9 -> (-0,5; -0,5)

double[] arrayB = new double[2];
double[] arrayK = new double[2];

Console.Write("Введите параметр b1: ");
arrayB[0] = Convert.ToDouble(Console.ReadLine());
Console.Write("Введите параметр k1: ");
arrayK[0] = Convert.ToDouble(Console.ReadLine());
Console.Write("Введите параметр b2: ");
arrayB[1] = Convert.ToDouble(Console.ReadLine());
Console.Write("Введите параметр k2: ");
arrayK[1] = Convert.ToDouble(Console.ReadLine());

double x = -(arrayB[0] - arrayB[1]) / (arrayK[0] - arrayK[1]);
double y = arrayK[0] * x + arrayB[0];

Console.WriteLine("Точка пересечения прямых: (" + Math.Round(x,1) + "; " + Math.Round(y,1) + ")");
