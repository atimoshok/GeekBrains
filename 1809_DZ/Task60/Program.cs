// Напишите программу, которая заполнит спирально массив 4 на 4.
// Например, на выходе получается вот такой массив:
// 01 02 03 04
// 12 13 14 05
// 11 16 15 06
// 10 09 08 07

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

int[,] SpiralFillMatrix(int[,] matrix)
{
    int rows = matrix.GetLength(0);
    int columns = matrix.GetLength(1);
    int element = 1;
    int iterations = Math.Min(rows, columns);
    int elementNumber = rows * columns;
    while (element <= elementNumber)
    {
        for (int j = matrix.GetLength(1) - columns; j < columns; j++)
        {
            int i = matrix.GetLength(1) - columns;
            matrix[i, j] = element;
            element++;
        }
        for (int i = matrix.GetLength(0) - rows + 1; i < rows; i++)
        {
            int j = columns - 1;
            matrix[i, j] = element;
            element++;
        }

        if (element > elementNumber) return matrix;
        else
        {
            for (int j = columns - 2; j >= matrix.GetLength(1) - columns; j--)
            {
                int i = rows - 1;
                matrix[i, j] = element;
                element++;
            }
            for (int i = rows - 2; i >= matrix.GetLength(0) - rows + 1; i--)
            {
                int j = matrix.GetLength(0) - rows;
                matrix[i, j] = element;
                element++;
            }

            rows -= 1;
            columns -= 1;
            //PrintMatrix(matrix);
            iterations -= 2;
        }
    }
    return matrix;
}

Console.Write("Задайте число строк: ");
int rows = Convert.ToInt32(Console.ReadLine());
Console.Write("Задайте число столбцов: ");
int cols = Convert.ToInt32(Console.ReadLine());

int[,] matrix = new int[rows, cols];
PrintMatrix(SpiralFillMatrix(matrix));