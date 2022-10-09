// Задайте две матрицы. Напишите программу, которая будет находить произведение двух матриц.
// Например, даны 2 матрицы:
// 2 4 | 3 4
// 3 2 | 3 3
// Результирующая матрица будет:
// 18 20
// 15 18

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

int[,] MatrixMultiplication (int[,] firstMatrix, int[,] secondMatrix)
{
    int[,] resultMatrix = new int[firstMatrix.GetLength(0), secondMatrix.GetLength(1)];
    if(firstMatrix.GetLength(1) != secondMatrix.GetLength(0))
    {
        Console.WriteLine("ОШИБКА! Число столбцов первой матрицы НЕ совпадает с числом строк второй матрицы");
        return resultMatrix;
    }
    else
    {
        for(int i = 0; i < firstMatrix.GetLength(0); i++)
        {
            for(int j = 0; j < secondMatrix.GetLength(1); j++)
            {
                int resultElement = 0;
                for (int k = 0; k < firstMatrix.GetLength(1); k++)
                {
                    resultElement += firstMatrix[i, k] * secondMatrix[k, j];
                }
                resultMatrix[i, j] = resultElement;
            }
        }
        return resultMatrix;
    }
}

//задаем первую матрицу
Console.Write("Задайте число строк ПЕРВОЙ матрицы: ");
int firstMatrixRows = Convert.ToInt32(Console.ReadLine());
Console.Write("Задайте число столбцов ПЕРВОЙ матрицы: ");
int firstMatrixCols = Convert.ToInt32(Console.ReadLine());
int[,] firstMatrix = CreateMatrix(firstMatrixRows, firstMatrixCols);
PrintMatrix(firstMatrix);

//задаем вторую матрицу
Console.Write("Задайте число строк ВТОРОЙ матрицы: ");
int secondMatrixRows = Convert.ToInt32(Console.ReadLine());
Console.Write("Задайте число столбцов ВТОРОЙ матрицы: ");
int secondMatrixCols = Convert.ToInt32(Console.ReadLine());
int[,] secondMatrix = CreateMatrix(secondMatrixRows, secondMatrixCols);
PrintMatrix(secondMatrix);

//выводим произведение матриц
Console.WriteLine("Результирующая матрица:");
PrintMatrix(MatrixMultiplication(firstMatrix, secondMatrix));