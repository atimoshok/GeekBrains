// Задайте прямоугольный двумерный массив. Напишите программу, которая будет находить строку с наименьшей суммой элементов.
// Например, задан массив:

// 1 4 7 2
// 5 9 2 3
// 8 4 2 4
// 5 2 6 7

// Программа считает сумму элементов в каждой строке и выдаёт номер строки с наименьшей суммой элементов: 1 строка

int[,] CreateMatrix(int row, int col, int valueMin = 1, int valueMax = 10)
{
    int[,] resultMatrix = new int[row, col];
    for (int i = 0; i < row; i++)
    {
        for (int j = 0; j < col; j++)
        {
            resultMatrix[i, j] = new Random().Next(valueMin, valueMax);
        }
    }
    return resultMatrix;
}

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

int RowSum(int[,] matrix, int rowNumber)
{
    int sum = 0;
    int length = matrix.GetLength(1);
    for (int i = 0; i < length; i++)
    {
        sum += matrix[rowNumber, i];
    }
    return sum;
}

Console.Write("Задайте число строк: ");
int rows = Convert.ToInt32(Console.ReadLine());
Console.Write("Задайте число столбцов: ");
int cols = Convert.ToInt32(Console.ReadLine());

int[,] matrix = CreateMatrix(rows, cols);
PrintMatrix(matrix);
Console.WriteLine();

int minRowNum = 0;
int minRowSum = RowSum(matrix, minRowNum);
for (int i = 1; i < rows; i++)
{
    int currentRowSum = RowSum(matrix, i);
    if (currentRowSum < minRowSum)
    {
        minRowSum = currentRowSum;
        minRowNum = i;
    }
}
Console.WriteLine($"Номер строки с наименьшей суммой элементов: {minRowNum + 1} \nСумма = {minRowSum}");