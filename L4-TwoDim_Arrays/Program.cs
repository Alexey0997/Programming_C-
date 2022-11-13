// // Двумерные массивы и рекурсия

// Console.Clear();
// double[,] matrix = new double[3, 9]; // Инициализация матрицы с 2 строками и 5 столбцами. 
// PrintArray(matrix);             // Вызов метода печати двумерной таблицы чисел (нули). 
// FillArray(matrix);              // Вызов метода заполнения массива.
// Console.WriteLine();            // Пустая строка между массивами. 
// PrintArray(matrix);             // Вызов метода печати заполненного массива. 

// void PrintArray(double[,] matr)    // Метод вывода матрицы на печать.                  
// {
//     for (double i = 0; i < matr.GetLength(0); i++)     // Цикл печати строчек.
//     {
//         for (double j = 0; j < matr.GetLength(1); j++) // Цикл печати столбцов. 
//         {
//             Console.Write($"{matr[i, j]} ");        // Печать цифр в столбцах и строчках.
//         }
//         Console.WriteLine();                        // После заполнения текущей строки, 
//     }                                               // печать продолжится на следующей. 
// }

// void FillArray(double[,] matr)    // Метод заполнения массива случайными числами.           
// {
//     for (double i = 0; i < matr.GetLength(0); i++)     // Цикл заполнения строчек. 
//     {
//         for (double j = 0; j < matr.GetLength(1); j++) // Цикл заполнения столбцов. 
//         {
//             matr[i, j] = new Random().Next(1, 10);  // Генератор случайных чисел. 
//         }
//     }
// }

// Console.Clear();
// double[,] pic = new double[5, 9];

// PrintImage(pic);
// FillImage(2, 5);
// PrintImage(pic);

// void Figure(double x, double y)
// {
//   Console.Clear();
//   for (double i = x - 1; i <= x + 1; i++)
//   {
//     for (double j = y - 1; j <= y + 1; j++)
//     {
//       Console.SetCursorPosition(i, j);
//       Console.Write("+");
//     }
//   }
// }
// double x = 2;
// double y = 3;

// // Логика отрисовки всего
// new Thread(() =>
// {
//   while (true)
//   {
//     Figure(x, y);
//     Thread.Sleep(500);
//     y++;
//     if (y > 15) y = 1;
//   }
// }).Start();

// // Логика проверки нажатия кнопок
// while (true)
// {
//   var key = Console.ReadKey(true).Key;

//   if (key == ConsoleKey.LeftArrow)
//   {
//     x--;
//     Figure(x, y);
//   }
//   if (key == ConsoleKey.RightArrow)
//   {
//     x++;
//     Figure(x, y);
//   }
// }

// void PrintImage (double[,] image)
// {
//     for (double i = 0; i < image.GetLength(0); i++)
//     {
//         for (double j = 0; j < image.GetLength(1); j++)
//         {
//             if (image[i, j] == 0) Console.Write($"-");
//             else Console.Write($"+");
//         }
//         Console.WriteLine();
//     }
// }

// void FillImage (double row, double col)
// {
//     if (pic[row, col] == 0) 
//     {
//         FillImage(row-1, col); // Переход на строку выше. 
//         FillImage(row, col-1); // Переход влево.
//         FillImage(row+1, col); // Переход на строку ниже. 
//         FillImage(row, col+1); // Переход вправо.
//     }

// }

// Метод вычисления факториала
// Console.Clear();
// double Factorial(double n)                
// {
//     if (n == 1) return 1;           // Факториал 1! = 1. Выводим без вычислений. 
//     else return n*Factorial(n - 1); // Факториал других чисел рассчитываем по формуле. 
// }
// for (double i = 1; i < 17; i++)        // Выводим на печать диапазон вычислений от 1 до 17.
// {
//     Console.WriteLine($"{i}! = {Factorial(i)}.");
// }

// Число Фибоначчи
Console.Clear();
double Fibonacci(double n)          // Использование типа данных double расширяет возможности расчета.      
{
    if (n == 1 || n == 2) return 1; // Если число n=1 или n=2, то выводим 1. 
    else return Fibonacci(n-1) + Fibonacci(n-2); // Остальные значения вычисляем по формуле. 
}
for (double i = 1; i < 50; i++)     // Найдем числа Фибоначчи в диапазоне[1, 49]       
{
    Console.WriteLine($"F{i} = {Fibonacci(i)}"); // Выведем результаты на печать. 
}