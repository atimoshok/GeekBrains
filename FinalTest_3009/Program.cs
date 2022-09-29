// Написать программу, которая из имеющегося массива строк формирует массив из строк,
// длина которых <= 3 символа. Первоначальный массив можно ввести с клавиатуры, либо задать на старте выполнения алгоритма.
// При решении не рекомендуется пользоваться коллекциями, лучше обойтись исключиельно массивами.

string[] FillArray(int length)
{
    string[] array = new string[length];
    for (int i = 0; i < length; i++)
    {
        Console.Write($"Введите {i + 1} элемент: ");
        array[i] = Console.ReadLine();
    }
    return array;
}

void PrintArray(string[] array)
{
    for (int i = 0; i < array.Length; i++)
    {
        Console.Write(array[i] + " ");
    }
    Console.WriteLine();
}

string[] ArrayCharCut(string[] incomeArray, int charLength)
{
    int length = incomeArray.Length;
    int j = 0;
    string[] newArray = new string[length];
    for (int i = 0; i < length; i++)
    {
        if (incomeArray[i].Length <= charLength)
        {
            newArray[j] = incomeArray[i];
            j++;
        }
    }
    return newArray;
}

Console.Write("Укажите длину массива: ");
int length = Convert.ToInt32(Console.ReadLine());

string[] incomeArray = FillArray(length);
Console.WriteLine("\nНачальный массив:");
PrintArray(incomeArray);

Console.Write("Укажите максимальную длину символов для элемента в новом массиве: ");
int maxСharLength = Convert.ToInt32(Console.ReadLine());
Console.WriteLine("\nОбработанный массив:");
PrintArray(ArrayCharCut(incomeArray, maxСharLength));
