﻿// Задача 68: Напишите программу вычисления функции Аккермана с помощью рекурсии. 
// Даны два неотрицательных числа m и n.
// m = 2, n = 3 -> A(m,n) = 9
// m = 3, n = 2 -> A(m,n) = 29

// ОСНОВНАЯ ПРОГРАММА
Console.Clear();
Console.Write("Введите целое число M >= 0: ");
int m = int.Parse(Console.ReadLine()!);
Console.Write("Введите целое число N >= 0: ");
int n = int.Parse(Console.ReadLine()!);
Console.WriteLine();
Console.Write($"Значение функции Аккермана для чисел {m} и {n}"
            + $" = {AkkerFun(m, n)} ");  // Метод - рассчет и печать суммы элементов.

// МЕТОД вычисления функции Аккермана с помощью рекурсии 
int AkkerFun(int m, int n) 
{                                 // В зависимости от значения переменных функция Аккермана                 
    int a = 2;                    // может рассчитываться по трем вариантам:
    if (m == 0) return n + 1;     // 1. При m = 0, а n > 0.
    else if (n == 0 && m > 0)     // 2. При n = 0, а m > 0.
    {
        return AkkerFun(m - 1, 1);                      
    }
    else                          // 3. При вводе чисел m и n > 0
    {                                                    
        return (AkkerFun(m - 1, AkkerFun(m, n - 1)));    
    }
}