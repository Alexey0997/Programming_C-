// Задача 64: Задайте значение N. Напишите программу, которая выведет все чётные числа 
// в промежутке от N до 1.
// N = 5 -> "4, 2"
// N = 8 -> "8, 6, 4, 2"

// ОСНОВНАЯ ЧАСТЬ ПРОГРАММЫ
Console.Clear();
Console.Write("Введите целое число N > 1: ");
int num = int.Parse(Console.ReadLine()!);
Console.WriteLine($"В промежутке от 1 до {num} находятся следующие четные числа: ");
Console.Write($"{PrintNums(2, num)} ");            // Метод вывода на печать четных чисел. 

// МЕТОД 
string PrintNums(int start, int end)
{
    if (num == start) return start.ToString();     // При вводе числа 2 печатаем 2.              
    if (num % 2 == 0) return (start + " " + PrintNums(start + 2, end));
    else                                           // Если введено четное число, то  
    {                                              // печатаем числа [2, num].
        num = num - 1;                             // Ввод нечетного числа:
        if (num == start) return start.ToString(); // - если ввели 3, то печатаем 2.
        return (start + " " + PrintNums(start + 2, end)); // Используем рекурсию.
    }                                              // - если нечетное число > 3,  
}                                                  // то печатаем четные числа 
                                                   // в диапазоне [2, num - 1].