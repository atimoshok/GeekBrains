// Задайте двумерный массив. Напишите программу, которая упорядочит по убыванию элементы каждой строки двумерного массива.
// Например, задан массив:
// 1 4 7 2
// 5 9 2 3
// 8 4 2 4
// В итоге получается вот такой массив:
// 7 4 2 1
// 9 5 3 2
// 8 4 4 2

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

int[,] SortMatrixRows(int[,] matrix)
{
    int rows = matrix.GetLength(0);
    int cols = matrix.GetLength(1);
    for (int i = 0; i < rows; i++)
    {
        int temp;
        for (int j = 0; j < cols; j++)
        {
            for (int k = j + 1; k < cols; k++)
            {
                if (matrix[i, j] < matrix[i, k])
                {
                    temp = matrix[i, j];
                    matrix[i, j] = matrix[i, k];
                    matrix[i, k] = temp;
                }
            }
        }
    }
    return matrix;
}

Console.Write("Задайте число строк: ");
int rows = Convert.ToInt32(Console.ReadLine());
Console.Write("Задайте число столбцов: ");
int cols = Convert.ToInt32(Console.ReadLine());

int[,] matrix = CreateMatrix(rows, cols);
PrintMatrix(matrix);
Console.WriteLine("Сортированная матрица:");
PrintMatrix(SortMatrixRows(matrix));

