// Напишите программу, которая на вход принимает позиции элемента в двумерном массиве,
// и возвращает значение этого элемента или же указание, что такого элемента нет.

// Например, задан массив:
// 1 4 7 2
// 5 9 2 3
// 8 4 2 4

// 17 -> такого числа в массиве нет

void PrintMatrix(int[,] matrix)
{
    int rows = matrix.GetLength(0);
    int cols = matrix.GetLength(1);

    for (int i = 0; i < rows; i++)
    {
        for (int j = 0; j < cols; j++)
        {
            Console.Write(matrix[i, j] + "\t");
        }
        Console.WriteLine();
    }
}

int[,] FillMatrix(int rows, int cols)
{
    int[,] matrix = new int[rows, cols];
    for (int i = 0; i < rows; i++)
    {
        for (int j = 0; j < cols; j++)
        {
            matrix[i, j] = new Random().Next(0, 100);
        }
    }
    return matrix;
}

int CheckElement(int[,] matrix, int posRow, int posCol)
{
    // Console.WriteLine(matrix.GetLength(0));
    // Console.WriteLine(matrix.GetLength(1));
    // Console.WriteLine(posRow);
    // Console.WriteLine(posCol);
    if (posRow < matrix.GetLength(0) && posCol < matrix.GetLength(1)) return matrix[posRow, posCol];
    else return -1;
}

Console.Write("Введите количество строк: ");
int m = Convert.ToInt32(Console.ReadLine());
Console.Write("Введите количество столбцов: ");
int n = Convert.ToInt32(Console.ReadLine());

int[,] matrix = FillMatrix(m, n);
PrintMatrix(matrix);

Console.WriteLine("Укажите позицию элемента в двумерном массиве: ");
int pos1 = Convert.ToInt32(Console.ReadLine());
int pos2 = Convert.ToInt32(Console.ReadLine());

if (CheckElement(matrix, pos1, pos2) == -1) System.Console.WriteLine("Такого элемента в массиве нет");
else Console.WriteLine(CheckElement(matrix, pos1, pos2));