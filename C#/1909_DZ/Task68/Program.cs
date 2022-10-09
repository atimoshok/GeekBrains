// Напишите программу вычисления функции Аккермана с помощью рекурсии. Даны два неотрицательных числа m и n.
// m = 2, n = 3 -> A(m,n) = 9
// m = 3, n = 2 -> A(m,n) = 29

Console.Write("Введите число m: ");
int m = Convert.ToInt32(Console.ReadLine());
Console.Write("Введите число n: ");
int n = Convert.ToInt32(Console.ReadLine());

int AkkermanFunction(int m, int n)
{
    int result = n;
    if (m == 0) return n + 1;
    else
    {
        result = AkkermanFunction(m, result - 1);
        return AkkermanFunction(m - 1, result);
    }
}

Console.WriteLine(AkkermanFunction(m, n));

// System.Console.WriteLine("Введите число N: ");
// int N = Convert.ToInt32(Console.ReadLine());

// int FactN (int number)
// {
//     if (number == 0) return 1;
//     else return number * FactN (number - 1);
// }

// Console.WriteLine(FactN(N));