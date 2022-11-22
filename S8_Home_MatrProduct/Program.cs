// Задача 58: Задайте две матрицы. Напишите программу, которая будет находить 
// произведение двух матриц.
// Например, даны 2 матрицы:
// 2 4 | 3 4
// 3 2 | 3 3
// Результирующая матрица будет:
// 18 20
// 15 18

// Формирование матрицы А.
Console.Clear();
int[,] matrixA = GetMatrix(3, 3, 0, 10);                  // Метод № 1 - формирование матриц.
Console.WriteLine("Матрица А: ");
PrintMatrix(matrixA);                                     // Метод № 2 - печать матрицы. 
Console.WriteLine();
// Формирование матрицы В.
int[,] matrixB = GetMatrix(3, 3, 0, 10);
Console.WriteLine("Матрица В: ");
PrintMatrix(matrixB);                                      
Console.WriteLine();
// Формирования матрицы, равной произведению матриц А и В.
int[,] productABuctAB = MatrixProduct(matrixA, matrixB); // Метод № 3 - произведение матриц.
Console.WriteLine("Результат произведения матриц А и В:");
PrintMatrix(productABuctAB);

// МЕТОДЫ № 1-3.
// Метод № 1 - формирование матриц. 
int[,] GetMatrix(int m, int n, int minValue, int maxValue)
{
    int[,] inMatrix = new int[m, n];
    for (int i = 0; i < m; i++)
    {
        for (int j = 0; j < n; j++)
        {
            inMatrix[i, j] = new Random().Next(minValue, maxValue + 1);
        }
    }
    return inMatrix;
}

// Метод № 2 - печать массива.  
void PrintMatrix(int[,] inMatrix)
{
    for (int i = 0; i < inMatrix.GetLength(0); i++)
    {
        for (int j = 0; j < inMatrix.GetLength(1); j++)
        {
            Console.Write($"{inMatrix[i, j]} ");
        }
        Console.WriteLine();
    }
}

// Метод № 3 - произведение матриц.
int[,] MatrixProduct(int[,] matrixA, int[,] matrixB) // Аргументы - матрицы А и В.
{
    int[,] result = new int[matrixA.GetLength(0), matrixA.GetLength(1)]; // Инициализация новой матрицы.
    for (int i = 0; i < matrixA.GetLength(0); i++)
    {
        for (int j = 0; j < matrixA.GetLength(1); j++)
        {
            int productAB = 0;
            for (int k = 0; k < matrixA.GetLength(1); k++) 
            {
                productAB += matrixA[i, k] * matrixB[k, j]; // Перемножение совместимых матриц. 
            }   // Элементы строки матрицы А умножаются на элементы соотв. стобца матрицы В,
            result[i, j] = productAB; // а полученные результаты складываются и записываются
        }                             // в качестве элементов строки новой матрицы. 
    }
    return result; // Выдача результата - матрицы, равной произведению матриц А и В.
}
