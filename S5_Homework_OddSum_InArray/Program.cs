// Задача 36. Задайте одномерный массив, заполненный случайными числами. 
// Найдите сумму элементов, стоящих на нечётных позициях.
// Например, [3, 7, 23, 12] -> 19, [-4, -6, 89, 6] -> 0
Console.Clear();                     
int[] array = GetArray(9, -9, 9);       // Инициализация одномерного массива.
int oddSum = 0;                         // Ввод переменной для подсчета суммы.
for (int i=0; i< array.Length; i++)     // Условия цикла. 
{                                       // Если номер элемента массива 
    if (i % 2 != 0) oddSum += array[i]; // не делится на 2 без остатка, то 
}                                       // он нечетный и его значение добавляем к сумме.
Console.WriteLine();                    // Печать результата с новой строки. 
Console.Write($"Сумма элементов, стоящих на нечётных позициях, = {oddSum}.");

int[] GetArray(int size, int minValue, int maxValue) // Метод формирования массива. 
{
    int[] res = new int[size];
    for (int i = 0; i < size; i++)
    {
        res[i] = new Random().Next(minValue, maxValue + 1);
        Console.Write($"{res[i]} ");
    }
    return res;
}