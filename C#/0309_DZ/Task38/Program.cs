// Задайте массив вещественных чисел. Найдите разницу между максимальным и минимальным элементов массива.

// [3 7 22 2 78] -> 76

double[] array = new double[10];

for (int i = 0; i < array.Length; i++)
{
    array[i] = new Random().Next(10, 100);
    Console.Write(array[i] + " ");
}

double max = array[0], min = array[0];

for (int i = 1; i < array.Length; i++)
{
    if (array[i] > max) max = array[i];
    else if (array[i] < min) min = array[i];
}

Console.WriteLine($"\nРазница между максимальным и минимальным элементом массива: {max - min}");
