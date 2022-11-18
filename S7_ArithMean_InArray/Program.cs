// Задача 52. Задайте двумерный массив из целых чисел. Найдите среднее арифметическое
//  элементов в каждом столбце. Например, задан массив:
// 1 4 7 2
// 5 9 2 3
// 8 4 2 4
// Среднее арифметическое каждого столбца: 4,6; 5,6; 3,6; 3.

// ОСНОВНАЯ ПРОГРАММА
Console.Clear();
Console.Write("Введите количество строк массива: ");    // Строки.
int rows = int.Parse(Console.ReadLine()!);
Console.Write("Введите количество столбцов массива: "); // Столбцы. 
int columns = int.Parse(Console.ReadLine()!);
int[,] array = GetArray(rows, columns, 0, 10);          // Метод № 1 - формирование массива.
PrintArray(array);                                      // Метод № 2 - печать. 
Console.Write($"Укажите № столбца от 1 до {columns} для расчета среднего арифметического: ");
int col = int.Parse(Console.ReadLine()!) - 1;           // Учитываем, что нумерация с 0.
Console.Write($"Среднее арифметическое чисел данного столбца = {ArithMean(array, col)}.");
// Метод № 3 - расчет ср. арифм. 
// МЕТОДЫ
int[,] GetArray(int m, int n, int minValue, int maxValue) // Метод № 1 - формирование массива. 
{
    int[,] result = new int[m, n];
    for (int i = 0; i < m; i++)
    {
        for (int j = 0; j < n; j++)
        {
            result[i, j] = new Random().Next(minValue, maxValue + 1);
        }
    }
    return result;
}

void PrintArray(int[,] inArray)                 // Метод № 2 - печать массива.                  
{
    for (int i = 0; i < inArray.GetLength(0); i++)
    {
        for (int j = 0; j < inArray.GetLength(1); j++)
        {
            Console.Write($"{inArray[i, j]} ");
        }
        Console.WriteLine();
    }
}

// double ArithMean(int[,] inArray, int col)   // Метод № 3 - расчет ср. арифметического.      
// {                                           // Аргументы - массив и номер столбца,  
//     double res = 0;                         // введенный пользователем. 
//     for (int i = 0; i < inArray.GetLength(0); i++)
//     {
//         for (int j = 0; j < inArray.GetLength(1); j++)
//         {
//             if (j == col) res = (res + inArray[i, j]); // Находим сумму чисел в столбце. 
//         }
//     }
//     res = res / inArray.GetLength(0);                  // Сумму делим на количество строк. 
//     return res;
// }

double ArithMean(int[,] inArray, int col)   // Метод № 3 - расчет ср. арифметического.      
{                                           // Аргументы - массив и номер столбца,  
    double res = 0;                         // введенный пользователем. 
    for (int i = 0; i < inArray.GetLength(0); i++)
    {
        res = res + inArray[i, col];        // Находим сумму элементов заданной строки. 
    }
    res = res / inArray.GetLength(0);       // Сумму делим на количество строк. 
    return res;                             // Возвращаем результат. 
}