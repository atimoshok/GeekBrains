// Задайте значения M и N. Напишите программу, которая найдёт сумму натуральных элементов в промежутке от M до N.
// M = 1; N = 15 -> 120
// M = 4; N = 8. -> 30

int SequenceSum(double start, double end)
{
    int sum = 0;
    for (int i = Convert.ToInt32(Math.Ceiling(start)); i <= Convert.ToInt32(Math.Truncate(end)); i++)
    {
        sum += i;
    }
    return sum;
}

Console.Write("Введите науральное число начала промежутка (M): ");
double M = Convert.ToDouble(Console.ReadLine());
Console.Write("Введите науральное число конца промежутка (N): ");
double N = Convert.ToDouble(Console.ReadLine());

Console.WriteLine($"Сумма натуральных элементов промежука от {M} до {N} равна: {SequenceSum(M, N)}");