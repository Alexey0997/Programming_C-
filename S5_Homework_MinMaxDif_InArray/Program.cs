// Задача 38. Задайте массив вещественных чисел. 
// Найдите разницу между максимальным и минимальным элементами массива.
// Например, [3 7 22 2 78] -> 76.

Console.Clear();                         // Отчистка консоли.  
double[] array = new double[8];         // Инициализация массива вещественных чисел.
FillArray(array);                        // Вызов метода заполнения массива. 
PrintArray(array);                       // Вызов метода печати массива. 
double min = array[0];                   // Ввод переменной минимального значения.
for (int i = 0; i < array.Length; i++)   // Цикл исследования элементов массива. 
{
    if (min > array[i]) min = array[i];  // Определение минимального элемента. 
}
Console.WriteLine();                     // Печать минимального значения с новой строки. 
Console.Write($"Минимальный элемент массива = {min}.");

double max = array[0];                   // Ввод переменной максимального значения. 
for (int i = 0; i < array.Length; i++)   // Цикл исследования массива. 
{
    if (max < array[i]) max = array[i];  // Определение максимального элемента. 
}
Console.WriteLine();                     // Печать максимального значения с новой строки. 
Console.Write($"Максимальный элемент массива = {max}.");
Console.WriteLine();                     // Вывод на печать разницы между мин. и макс. значениями. 
Console.Write($"Разница между максимальным и минимальным элементами массива = {max - min}.");

// МЕТОДЫ (ПОДПРОГРАММЫ)
void FillArray(double[] array)             // Метод заполнения массива. 
{
    for (int i = 0; i < array.Length; i++) // Условия выхода из цикла. 
    {                                      // Генерация случайных вещественных чисел в заданном диапазоне. 
        array[i] = Convert.ToDouble(new Random().Next(-100, 100));
        // array[i] = Convert.ToDouble(new Random().Next(-100, 1000))/100; // Если нужны дробные числа. 
    }
}

void PrintArray(double[] array)            // Метод вывода массива на печать.
{
    Console.WriteLine();                   // Печать с новой строки. 
    Console.Write("[ ");                   // Открытие квадратных скобок. 
    for (int i = 0; i < array.Length; i++) // Условия выхода из цикла. 
    {
        Console.Write(array[i] + " ");     // Печать элементов массива через пробел.
    }
    Console.Write("]");                    // Закрывающая квадратная скобка. 
}


// Задача 38: Задайте массив вещественных чисел. 
// Найдите разницу между максимальным и минимальным элементами массива.
// Например, [3 7 22 2 78] -> 76.
// Console.Clear();
// int[] array = GetArray(10, 1, 100);
// int minNumber = array[0];

// for (int i = 0; i < array.Length; i++)
// {
//     if(minNumber > array[i]) minNumber = array[i];
// }
// Console.WriteLine();
// Console.Write($"Минимальный элемент массива = {minNumber}.");

// int maxNumber = array[0];
// for (int i = 0; i < array.Length; i++)
// {
//     if(maxNumber < array[i]) maxNumber = array[i];
// }
// Console.WriteLine();
// Console.Write($"Максимальный элемент массива = {maxNumber}.");
// int res = maxNumber - minNumber;
// Console.WriteLine();
// Console.Write($"Разница между максимальным и минимальным элементами массива = {res}.");

// // Метод формирования массива. 
// int[] GetArray(int size, int minValue, int maxValue) 
// {
//     int[] res = new int[size];
//     for (int i = 0; i < size; i++)
//     {
//         res[i] = new Random().Next(minValue, maxValue + 1);
//         Console.Write($"{res[i]} ");
//     }
//     return res;
// }