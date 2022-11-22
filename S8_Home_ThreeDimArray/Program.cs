// Задача 60. Сформируйте трёхмерный массив из неповторяющихся двузначных чисел. 
// Напишите программу, которая будет построчно выводить массив, 
// добавляя индексы каждого элемента.
// Массив размером 2 x 2 x 2
// 66(0,0,0) 25(0,1,0)
// 34(1,0,0) 41(1,1,0)
// 27(0,0,1) 90(0,1,1)
// 26(1,0,1) 55(1,1,1)

// ОСНОВНАЯ ПРОГРАММА
Console.Clear();
int[,,] array = new int[2, 2, 2];
FillArray(array);  // Метод № 1 - заполнение массива.
CheckArray(array); // Метод № 2 - проверка и замена повторяющихся элементов. 
PrintArray(array); // Метод № 3 - вывод массива на печать.

// МЕТОДЫ
// Метод № 1 - заполнение массива. 
void FillArray(int[,,] array)
{
    for (int i = 0; i < array.GetLength(0); i++)             // Страницы.
    {
        for (int j = 0; j < array.GetLength(1); j++)         // Строки.
        {
            for (int k = 0; k < array.GetLength(2); k++)     // Столбцы. 
            {
                array[i, j, k] = new Random().Next(10, 100); // Заполнение двузначными числами. 
            }
        }
    }
}

// Метод № 2 - проверка и замена повторяющихся элементов массива. 
void CheckArray(int[,,] array)
{
    int maxNumber = array[0, 0, 0];
    for (int i = 0; i < array.GetLength(0); i++)             // Страницы.
    {
        for (int j = 0; j < array.GetLength(1); j++)         // Строки.
        {
            for (int k = 0; k < array.GetLength(2); k++)     // Столбцы. 
            {   // Определим максимальный элемент массива. 
                if (array[i, j, k] > maxNumber) maxNumber = array[i, j, k];
                for (int x = 0 + 1; x < array.GetLength(0); x++)
                {
                    for (int y = j + 1; y < array.GetLength(1); y++)
                    {
                        for (int z = k + 1; z < array.GetLength(2); z++)
                        {
                            if (array[i, j, k] == array[x, y, z] && maxNumber < 98)
                             Console.WriteLine($"Оппачки {array[i, j, k]}");
                            {   // При совпадении элементов производим замену на max + 1.
                                maxNumber++;
                                if (maxNumber < 98) array[i, j, k] = maxNumber;
                                else Console.WriteLine("Возможности для замены элементов исчерпаны." 
                                                     + "Перезапустите программу.");
                                
                            }
                        }
                    }
                }
            }
        }
    }
}

// Метод № 3 - вывод массива на печать.
void PrintArray(int[,,] array)
{
    Console.WriteLine("Сформирован массив заданного размера.");
    Console.WriteLine();
    for (int i = 0; i < array.GetLength(0); i++)
    {
        Console.WriteLine("Страница № " + (i + 1));
        for (int j = 0; j < array.GetLength(1); j++)
        {
            for (int k = 0; k < array.GetLength(2); k++)
            {
                Console.Write($"{array[i, j, k]} {(i, j, k)}  ");
            }
            Console.WriteLine();
        }
        Console.WriteLine();
    }
}
