// Задача 28. Напишите программу, которая принимает на вход число N 
// и выдает произведение чисел от 1 до N. Например, 4 -> 24, 5 -> 120.
Console.Clear();
Console.WriteLine("Уважаемый пользователь, введите чило: ");
int number = int.Parse(Console.ReadLine()!);
Console.WriteLine($"Произведение чисел от 1 до {number} = {ProdNums(number)}.");

int ProdNums(int number)             // Опишем метод.
{
    int result = 1;                  // Присвоим переменной значение 1. 
    while(number > 1)                // Зададим условие выхода из цикла. 
    {
        result = result*number;      // Расчитаем произведение чисел от 1 до N. 
        number--;                    // Введем декремент. 
        Console.Write($"{result} "); // Выведем на печать промежуточные значения. 
    }
    Console.WriteLine();             // Перейдем на новую строчку.
    return result;                   // Вернем результат.
}