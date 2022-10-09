// Напишите цикл, который принимает на вход два числа (A и B) и возводит число A в натуральную степень B.

// 3, 5 -> 243 (3⁵)
// 2, 4 -> 16

Console.Write("Введите число, которое нужно возвести в степень: ");
int firstNumber = Convert.ToInt32(Console.ReadLine());
Console.Write("В какую степень возвести: ");
int secondNumber = Convert.ToInt32(Console.ReadLine());

int result = 1;

for (int i = 0; i < secondNumber; i++)
{
    result *= firstNumber;
}

System.Console.WriteLine($"Ответ: {result}");