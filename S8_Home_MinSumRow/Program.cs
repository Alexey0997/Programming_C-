// Задача 56: Задайте прямоугольный двумерный массив. Напишите программу, 
// которая будет находить строку с наименьшей суммой элементов.
// Например, задан массив:
// 1 4 7 2
// 5 9 2 3
// 8 4 2 4
// 5 2 6 7
// Программа считает сумму элементов в каждой строке и выдаёт номер строки 
// с наименьшей суммой элементов: 1 строка

Console.Clear();
Console.Write("Количество строк в массиве равно количеству столбцов. "
            + "Введите количество строк: ");
int rows = int.Parse(Console.ReadLine()!);
int columns = rows;
int[,] inArray = GetArray(rows, columns, 0, 10);     // Метод № 1 - формирование массива.
PrintArray(inArray);   // Метод № 2 - печать массива. 
Console.WriteLine();
MinSumRow(inArray);    // Метод № 3 - определение строки с минимальной суммой элементов. 

// МЕТОДЫ №№ 1-3.
// Метод № 1 - формирование массива. 
int[,] GetArray(int m, int n, int minValue, int maxValue) 
{
    int[,] inArray = new int[m, n];
    for (int i = 0; i < m; i++)
    {
        for (int j = 0; j < n; j++)
        {
            inArray[i, j] = new Random().Next(minValue, maxValue + 1);
        }
    }
    return inArray;
}

// Метод № 2 - печать массива. 
void PrintArray(int[,] inArray)                                  
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

// Метод № 3 - определения строки с минимальной суммой элементов.
void MinSumRow(int[,] inArray) 
{
    int minRow = 0;      // Сумма элементов первой строки - начальный минимум. 
    int sumRow = 0;      // Сумма элементов исследуемой строки. 
    int minSumRow = 0;   // Номер строки с минимальной суммой элементов. 
    for (int j = 0; j < inArray.GetLength(1); j++)
    {
        minRow = minRow + inArray[0, j];
    }
    for (int i = 0; i < inArray.GetLength(0); i++)
    {
        for (int j = 0; j < inArray.GetLength(1); j++)
        {
            sumRow = sumRow + inArray[i, j];
        }
        if (sumRow < minRow)
        {
            minRow = sumRow;
            minSumRow = i;
        }
        sumRow = 0;
    }
    Console.Write($"{minSumRow + 1} строка содержит наименьшую сумму элементов.");
}   // К индексу прибавляем 1, чтобы отсчет у пользователя начинался с первой строки.  