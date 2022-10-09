// // Задайте двумерный массив размера m на n, каждый элемент в массиве находится по формуле:
// // Aₘₙ = m+n. Выведите полученный массив на экран.

// // m = 3, n = 4.
// // 0 1 2 3
// // 1 2 3 4
// // 2 3 4 5

// Console.Write("Введите количество строк: ");
// int rows = Convert.ToInt32(Console.ReadLine());

// Console.Write("Введите количество столбцов: ");
// int columns = Convert.ToInt32(Console.ReadLine());

// // Cоздание и заполнение элементами массива
// // Matrix - прямоугольная табличка, которая состоит
// // из m строк и n столбцов (табличка)
// // m - cтрочки, n - столбцы, 0 - minRandom, 10 - maxRandom
// int[,] GetMatrix(int m, int n)
// {
//     int[,] matrix = new int[m, n];
//     for (int i = 0; i < m; i++) // строчки, matrix.GetLength(0) = m
//     {
//         // i, m, k, j
//         for (int j = 0; j < n; j++) //matrix.GetLength(1) = n, столбцы
//         {
//             matrix[i, j] = i + j;
//         }
//     }
//     return matrix;
// }

// // Напечатать массив
// void PrintMatrix(int[,] inputMatrix)
// {
//     for (int i = 0; i < inputMatrix.GetLength(0); i++)
//     {
//         for (int j = 0; j < inputMatrix.GetLength(1); j++)
//         {
//             Console.Write(inputMatrix[i, j] + "\t"); // Tab между элементами
//         }
//         Console.WriteLine();
//     }
// }
// // Получаем матрицу из rows строк и columns столбцов,
// // элементы от 0 до 10
// int[,] resultMatrix = GetMatrix(rows, columns);
// PrintMatrix(resultMatrix);


// // Задайте двумерный массив. Найдите элементы, у которых оба индекса чётные, и замените эти элементы на их квадраты.

// Console.Write("Введите количество строк: ");
// int rows = Convert.ToInt32(Console.ReadLine());

// Console.Write("Введите количество столбцов: ");
// int columns = Convert.ToInt32(Console.ReadLine());

// // Cоздание и заполнение элементами массива
// // Matrix - прямоугольная табличка, которая состоит
// // из m строк и n столбцов (табличка)
// // m - cтрочки, n - столбцы, 0 - minRandom, 10 - maxRandom
// int[,] GetMatrix(int m, int n, int minRandom, int maxRandom)
// {
//     int[,] matrix = new int[m, n];
//     for (int i = 0; i < m; i++) // строчки, matrix.GetLength(0) = m
//     {
//         // i, m, k, j
//         for (int j = 0; j < n; j++) //matrix.GetLength(1) = n, столбцы
//         {
//             matrix[i, j] = new Random().Next(minRandom, maxRandom + 1);
//         }
//     }
//     return matrix;
// }

// // Напечатать массив
// void PrintMatrix(int[,] inputMatrix)
// {
//     for (int i = 0; i < inputMatrix.GetLength(0); i++)
//     {
//         for (int j = 0; j < inputMatrix.GetLength(1); j++)
//         {
//             Console.Write(inputMatrix[i, j] + "\t"); // Tab между элементами
//         }
//         Console.WriteLine();
//     }
// }

// // Получаем матрицу из rows строк и columns столбцов,
// // элементы от 0 до 10
// int[,] resultMatrix = GetMatrix(rows, columns, 0, 10);
// PrintMatrix(resultMatrix);

// Console.WriteLine("Result matrix: ");

// for (int i = 0; i < rows; i++)
// {
//     for (int j = 0; j < columns; j++)
//     {
//         if (i % 2 == 0 && j % 2 == 0) resultMatrix[i, j] *= resultMatrix[i, j];
//         Console.Write(resultMatrix[i, j] + "\t");
//     }
//     Console.WriteLine();
// }



// Найдите сумму элементов главной диагонали. Например, задан массив:
// 1 4 7 2
// 5 9 2 3
// 8 4 2 4
// Сумма элементов главной диагонали: 1+9+2 = 12

Console.Write("Введите количество строк: ");
int rows = Convert.ToInt32(Console.ReadLine());

Console.Write("Введите количество столбцов: ");
int columns = Convert.ToInt32(Console.ReadLine());

// Cоздание и заполнение элементами массива
// Matrix - прямоугольная табличка, которая состоит
// из m строк и n столбцов (табличка)
// m - cтрочки, n - столбцы, 0 - minRandom, 10 - maxRandom
int[,] GetMatrix(int m, int n, int minRandom, int maxRandom)
{
    int[,] matrix = new int[m, n];
    for (int i = 0; i < matrix.GetLength(0); i++) // строчки, matrix.GetLength(0) = m
    {
        // i, m, k, j
        for (int j = 0; j < n; j++) //matrix.GetLength(1) = n, столбцы
        {
            matrix[i, j] = new Random().Next(minRandom, maxRandom + 1);
        }
    }
    return matrix;
}

// Напечатать массив
void PrintMatrix(int[,] inputMatrix)
{
    for (int i = 0; i < inputMatrix.GetLength(0); i++)
    {
        for (int j = 0; j < inputMatrix.GetLength(1); j++)
        {
            Console.Write(inputMatrix[i, j] + "\t"); // Tab между элементами
        }
        Console.WriteLine();
    }
}
// Получаем матрицу из rows строк и columns столбцов,
// элементы от 0 до 10
int[,] resultMatrix = GetMatrix(rows, columns, 0, 10);
PrintMatrix(resultMatrix);

int GetSumDiagonal(int[,] matrix)
{
    int sum = 0;
    int rows = matrix.GetLength(0);
    int columns = matrix.GetLength(1);
    for (int i = 0; i < rows; i++)
    {
        for (int j = 0; j < columns; j++)
        {
            if (i == j) sum += matrix[i, j];
        }
    }
    return sum;
}

Console.WriteLine($"Сумма главной диагонали : {GetSumDiagonal(resultMatrix)}");