// Задача 47. Задайте двумерный массив размером m×n, заполненный 
// случайными вещественными числами.
// m = 3, n = 4.
// 0,5 7 -2 -0,2
// 1 -3,3 8 -9,9
// 8 7,8 -7,1 9

// ОСНОВНАЯ ПРОГРАММА
Console.Clear();
Console.Write("Введите количество строк массива: ");
int rows = int.Parse(Console.ReadLine()!);
Console.Write("Введите количество столбцов массива: ");
int columns = int.Parse(Console.ReadLine()!);
double[,] array = GetArray(rows, columns);
PrintArray(array);

// МЕТОДЫ
double[,] GetArray(int m, int n)          // Метод формирования массива. 
{
    double[,] result = new double[m, n];
    for (int i = 0; i < m; i++)           // Строки.
    {
        for (int j = 0; j < n; j++)       // Столбцы.
        {                                
            result[i, j] = Convert.ToDouble(new Random().Next(-100, 100)) / 10;
        }                                 // Генератор случайных вещественных чисел. 
    }
    return result;
}

void PrintArray(double[,] inArray)      // Метод вывода массива на печать. 
{
    for (int i = 0; i < inArray.GetLength(0); i++)
    {
        for (int j = 0; j < inArray.GetLength(1); j++)
        {
            Console.Write($"{inArray[i, j]}  ");
        }
        Console.WriteLine();
    }
}
