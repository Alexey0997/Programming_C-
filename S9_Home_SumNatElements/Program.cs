// Задача 66: Задайте значения M и N. Напишите программу, которая найдёт сумму 
// натуральных элементов в промежутке от M до N.
// M = 1; N = 15 -> 120
// M = 4; N = 8. -> 30

// ОСНОВНАЯ ПРОГРАММА
Console.Clear();
Console.Write("Введите целое число M > 0: ");
int m = int.Parse(Console.ReadLine()!);
Console.Write("Введите число N >= M: ");
int n = int.Parse(Console.ReadLine()!);

Console.Write("В заданном диапазоне находятся следующие числа: [ ");
Console.Write($"{GetNumbers(m, n)} "); // Метод № 1 - печать чисел в заданном диапазоне. 
Console.Write("]");
Console.WriteLine();
Console.Write($"Сумма натуральных элементов в промежутке от {m} до {n}" 
            + $" = {GetSum(m, n)} ");  // Метод № 2 - рассчет и печать суммы элементов.


int GetNumbers(int m, int n)
{
    if (m == n) return n;
    else 
    {
        Console.Write(m + " ");
        return GetNumbers(m + 1, n);   // Определяем и выводим на печать числа 
    }                                  // с использованием рекурсии. 
}

int GetSum(int m, int n)
{
    int sum = m;                       
    if (m == n) return m;              // Если оба числа одинаковы, выводим m.
    else
    {
        sum = sum + GetSum(m + 1, n);  // Находим сумму чисел с использованием рекурсии.
        return sum;
    }
}