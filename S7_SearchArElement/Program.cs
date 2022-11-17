// Задача 50. Напишите программу, которая на вход принимает позиции элемента 
// в двумерном массиве, и возвращает значение этого элемента или же указание, 
// что такого элемента нет.
// Например, задан массив:
// 1 4 7 2
// 5 9 2 3
// 8 4 2 4
// (1, 7) -> такого элемента в массиве нет

// ОСНОВНАЯ ПРОГРАММА
Console.Clear();
int[,] array = GetArray(5, 5, 0, 20); // Вызов метода формирования массива. 
PrintArray(array);                    // Вызов метода печати массива. 
                                      // Запрос данных об искомом элементе.
Console.Write("Уважаемый пользователь, нумерация строк и столбцов начинаестя с № 1.");
Console.WriteLine();
Console.Write("Введите номер строки искомого элемента: ");
int row = int.Parse(Console.ReadLine()!) - 1;
Console.Write("Введите номер столбца искомого элемента: ");
int column = int.Parse(Console.ReadLine()!) - 1;
FindEl(array, row, column);           // Вызов метода поиска заданного элемента. 


// МЕТОДЫ
int[,] GetArray(int r, int c, int minValue, int maxValue) // Формирование масссива.
{
    int[,] result = new int[r, c];
    for (int i = 0; i < r; i++)
    {
        for (int j = 0; j < c; j++)
        {
            result[i, j] = new Random().Next(minValue, maxValue + 1);
        }
    }
    return result;
}

void PrintArray(int[,] inArray)          // Печать массива. 
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

void FindEl(int[,] inArray, int r, int c) // Поиск заданного элемента. 
{   // Если элемента нет в массиве, то выводим соответствующее сообщение.     
    if (row > array.GetLength(0) - 1 || column > array.GetLength(1) - 1)
    {
        Console.WriteLine("Такого элемента в массиве нет.");
    }
    else  // Если элемент находится в массиве, то сообщаем пользователю его значение.
    {
        for (int i = 0; i < inArray.GetLength(0); i++)
        {
            for (int j = 0; j < inArray.GetLength(1); j++)
            {
                if (i == r && j == c)
                {
                    Console.Write($"Значение элемента равно {inArray[i, j]}.");
                }
            }
        }
    }

}