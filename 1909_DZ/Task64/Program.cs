// Задайте значения M и N. Напишите программу, которая выведет все натуральные числа в промежутке от M до N.

// M = 1; N = 5. -> ""1, 2, 3, 4, 5""
// M = 4; N = 8. -> ""4, 6, 7, 8""

void Sequence(int start, int end)
{
    for (int i = start; i <= end; i++)
    {
        Console.Write(i + " ");
    }
}

Console.Write("Введите науральное число начала промежутка (M): ");
int M = Convert.ToInt32(Console.ReadLine());
Console.Write("Введите науральное число конца промежутка (N): ");
int N = Convert.ToInt32(Console.ReadLine());

Sequence(M, N);