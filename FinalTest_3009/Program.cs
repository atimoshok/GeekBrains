// Написать программу, которая из имеющегося массива строк формирует массив из строк,
// длина которых <= 3 символа. Первоначальный массив можно ввести с клавиатуры, либо задать на старте выполнения алгоритма.
// При решении не рекомендуется пользоваться коллекциями, лучше обойтись исключиельно массивами.

string[] FillArray(int length)
{
    string[] array = new string[length];
    for(int i = 0; i < length; i++)
    {
        array[i] = Console.ReadLine();
    }
    return array;
}

void ArrayCharCut(string[] incomeArray, int charLength)
{
    //string[] newArray[incomeArray.Length];
    Console.WriteLine(incomeArray.Length);
}

Console.Write("Укажите длину массива: ");
int length = Convert.ToInt32(Console.ReadLine());

string[] incomeArray = FillArray(length);
ArrayCharCut(incomeArray, length);
