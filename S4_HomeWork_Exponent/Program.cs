// Задача 25: Напишите цикл, который принимает на вход два числа (A и B) 
// и возводит число A в натуральную степень B. Например, 3, 5 -> 243 (3⁵), 2, 4 -> 16.
Console.Clear();
Console.WriteLine("Введите число А, которое Вы хотите возвести в степень B2: ");
int numberA = int.Parse(Console.ReadLine()!);
Console.WriteLine("Введите натуральное число В - степень, в которую Вы хотите возвести число А: ");
int numberB = int.Parse(Console.ReadLine()!);
Console.WriteLine($"Число {numberA} в степени {numberB} = {Exponent(numberA)}.");

int Exponent(int numberA)                         // Опишем метод.
{
    int result = numberA;                         // Присвоим начальному результату значение А.
    for(int count = 2; count <= numberB; count++) // Установим условия выхода из цикла. 
    {
        result = result*numberA;                  // Укажем формулу возведения в степень.
        Console.Write($"{result} ");              // Выведем промежуточные результаты.
    }
    Console.WriteLine();                          // Перейдем на новую строку. 
    return result;                                // Вернем резульат вычислений. 
}
