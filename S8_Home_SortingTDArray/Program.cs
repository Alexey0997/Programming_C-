// Задача 54: Задайте двумерный массив. Напишите программу, которая упорядочит 
// по убыванию элементы каждой строки двумерного массива.
// Например, задан массив:
// 1 4 7 2
// 5 9 2 3
// 8 4 2 4
// В итоге получается вот такой массив:
// 7 4 2 1
// 9 5 3 2
// 8 4 4 2

Console.Clear();
Console.Write("Введите количество строк массива: ");
int rows = int.Parse(Console.ReadLine()!);
Console.Write("Введите количество столбцов массива: ");
int columns = int.Parse(Console.ReadLine()!);
int[,] inArray = GetArray(rows, columns, 0, 10); // Метод № 1 - формирование массива.
Console.WriteLine("Исходный массив: ");
PrintArray(inArray);                             // Метод № 2 - печать массива. 
Console.WriteLine();
SortArray(inArray);                              // Метод № 3 - сортировка элементов массива.
Console.WriteLine("Новый массив:");
PrintArray(inArray);                             

// МЕТОДЫ
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

// Метод № 3 - сортировка элементов по убыванию в каждой строке. 
void SortArray(int[,] col)
{
    for (int i = 0; i < col.GetLength(0); i++)
    {
        for (int j = 0; j < col.GetLength(1) - 1; j++)
        {
            for (int index = 0; index < col.GetLength(1) - 1; index++) 
            {
                if (col[i, index] < col[i, index + 1]) // Сравнение двух элементов строки.
                {
                    int temp = 0;                      // Временная переменная. 
                    temp = col[i, index];              // Присвоение temp меньшего значения.
                    col[i, index] = col[i, index + 1]; // Записываем большее число на место меньшего.
                    col[i, index + 1] = temp;          // Записываем меньшее число на место большего 
                }                                      // с использованием временной переменной. 
            }
        }
    }
}