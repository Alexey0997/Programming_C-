// ЧЕТНОСТЬ/НЕЧЕТНОСТЬ 
/*Console.Clear();
Console.WriteLine("Уважаемый пользователь, введите целое число: ");
int number = int.Parse(Console.ReadLine());
int result = number%2;
if(result == 0)
{
    Console.WriteLine($"Число {number} является четным, т.к. оно делится на {2} без остатка.");
}
else
{
    Console.WriteLine($"Число {number} НЕ является четным, т.к. оно не делится на {2} без остатка.");
}*/

// СРАВНЕНИЕ ДВУХ ЧИСЕЛ
/*Console.Clear();
Console.WriteLine("Уважаемый пользователь, введите первое целое число: ");
int numberA = int.Parse(Console.ReadLine());
Console.WriteLine("Уважаемый пользователь, введите второе целое число: ");
int numberB = int.Parse(Console.ReadLine());
if(numberA == numberB)
{
    Console.WriteLine("Эти числа равны. Введите, пожалуйста, два разных целых числа.");
}
if(numberA > numberB)
{
    Console.WriteLine($"Число {numberA} больше числа {numberB}.");
}
else
{
    Console.WriteLine($"Число {numberB} больше числа {numberA}.");
}*/

// ДИАПАЗОН ЧЕТНЫХ ЧИСЕЛ ОТ 1 ДО N.
// Задача 8: Напишите программу, которая на вход принимает число N, 
// а на выходе показывает все четные числа от 1 до N.
/*Console.Clear();
Console.WriteLine("Уважаемый пользователь, введите целое положительное число: ");
int number = int.Parse(Console.ReadLine());
int count = 2; // Поскольку это первое четное число после 1.
Console.WriteLine($"В диапазоне от {1} до {number} имеются следующие четные числа: ");
while(count <= number)
{
    Console.Write($"{count}, ");
    count = count + 2;
}*/

// ВТОРАЯ ЦИФРА ТРЕХЗНАЧНОГО ЧИСЛА
// Задача 10: Напишите программу, которая принимает на вход трехзначное число
// и на выходе показывает вторую цифру этого числа. 

/*Console.Clear();
Console.WriteLine("Уважаемый пользователь, введите целое трехзначное число: ");
int number = int.Parse(Console.ReadLine());
if(number < 0) number = number * -1; // Перевод отрицательного числа в положительное.
int result = number/10%10;           // Функция поиска второй цифры трехзначного числа. 
Console.WriteLine($"Вторая цифра в заданном числе {result}.");*/

// ТРЕТЬЯ ЦИФРА ЗАДАННОГО ЧИСЛА
// Задача 13: Напишите программу, которая выводит третью цифру заданного числа 
// или сообщает, что третьей цифры нет.
/*Console.Clear();
Console.WriteLine("Уважаемый пользователь, введите целое число: ");
int number = int.Parse(Console.ReadLine());
// Определим количество цифр в числе, введенном пользователем. 
int count = 0;
int num = number;
while (num > 0)
{
    num = num/10;
    count++;
}
if(count < 3) // Если число двузначное, то сообщим об отсутствии третьей цифры. 
{
    Console.WriteLine("Введенное Вами число не содержит третьей цифры.");
}
else          // Создадим и заполним массив от максимального элемента к минимальному. 
{
    int[] array = new int [count]; // Созданим массив array, имеющий count элементов.
    int index = array.Length - 1;  // Найдем индекс последнего элемента.
    while(number > 0)              // Цикл по заполнению массива. 
    {
        array [index] = number%10; // Значение элемента равно остатку после деления. 
        number = number/10;        // Переход к следующей цифре числа. 
        index--;                   // Уменьшение индекса (справа на лево).
    }
Console.WriteLine($"Третья цифра в данном числе {array[2]}.");
}*/




