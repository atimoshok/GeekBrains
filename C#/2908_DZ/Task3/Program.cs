// Напишите программу, которая задаёт массив из 8 элементов и выводит их на экран.

// 1, 2, 5, 7, 19 -> [1, 2, 5, 7, 19]
// 6, 1, 33 -> [6, 1, 33]

int[] array = new int[8];

Console.WriteLine("Введите 8 эелементов в массив: ");
for (int i = 0; i < array.Length; i++)
{
    Console.Write($"{i+1} эелемент: ");
    array[i] = Convert.ToInt32(Console.ReadLine());
}

Console.WriteLine("\nВаш массив: ");
for (int i = 0; i < array.Length; i++)
{
    System.Console.Write(array[i] + " ");
}