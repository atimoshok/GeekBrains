// Пользователь вводит с клавиатуры M чисел. Посчитайте, сколько чисел больше 0 ввёл пользователь.

// 0, 7, 8, -2, -2 -> 2
// 1, -7, 567, 89, 223-> 3

Console.Write("Сколько чисел будете вводить? ");
int M = Convert.ToInt32(Console.ReadLine());

int number, count = 0;

for(int i = 0; i < M; i++)
{
    number = Convert.ToInt32(Console.ReadLine());
    if(number > 0) count++;
}

Console.WriteLine($"Вы ввели {count} положительных числа");