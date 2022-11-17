// Задача 52. Задайте двумерный массив из целых чисел. Найдите среднее арифметическое
//  элементов в каждом столбце. Например, задан массив:
// 1 4 7 2
// 5 9 2 3
// 8 4 2 4
// Среднее арифметическое каждого столбца: 4,6; 5,6; 3,6; 3.

// ОСНОВНАЯ ПРОГРАММА
Console.Clear();
Console.Write("Введите количество строк массива: ");
int rows = int.Parse(Console.ReadLine()!);
Console.Write("Введите количество столбцов массива: ");
int columns = int.Parse(Console.ReadLine()!);
int[,] array = GetArray(rows, columns, 0, 10);
PrintArray(array);
Console.Write($"Укажите № столбца от 1 до {columns} для расчета среднего арифметического: ");
int col = int.Parse(Console.ReadLine()!) - 1;
Console.Write($"Среднее арифметическое чисел данного столбца = {ArithMean(array, col)}.");

// МЕТОДЫ
int[,] GetArray(int m, int n, int minValue, int maxValue) // Метод формирования массива. 
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

void PrintArray(int[,] inArray)             // Метод вывода массива на печать.                  
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

double ArithMean(int[,] inArray, int col)   // Метод рассчета среднего арифметического.      
{                                           // Аргументы - массив и номер столбца,  
    double res = 0;                         // введенный пользователем. 
    for (int i = 0; i < inArray.GetLength(0); i++)
    {
        for (int j = 0; j < inArray.GetLength(1); j++)
        {
            if (j == col) res = (res + inArray[i, j]); // Находим сумму чисел в столбце. 
        }
    }
    res = res / inArray.GetLength(0);                  // Сумму делим на количество строк. 
    return res;
}