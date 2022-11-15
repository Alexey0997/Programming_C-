// Задача 41: Пользователь вводит с клавиатуры M чисел. Посчитайте, сколько чисел 
// больше 0 ввёл пользователь. // Например, 0, 7, 8, -2, -2 -> 2 или 1, -7, 567, 89, 223-> 3.

Console.Clear();
Console.Write("Укажите, сколько чисел Вы хотите ввести: ");
int M = int.Parse(Console.ReadLine());
int[] array = new int[M];
FillArray(array);
PrintArray(array);
PositiveNums(array);

void FillArray(int[] col)
{
    for (int i = 0; i < col.Length; i++)
    {
        Console.Write("Введите число: ");
        col[i] = int.Parse(Console.ReadLine());
    }
}
void PrintArray(int[] col)
{
    Console.Clear();
    Console.WriteLine();
    Console.Write("Введены следующие числа: [ ");
    for (int i = 0; i < col.Length; i++)
    {
        Console.Write($"{col[i]} ");
    }
    Console.Write("].");
}

void PositiveNums(int[] col)
{
    int nums = 0;
    foreach(int el in col)
    {
        if (el > 0) nums++;
    }
    Console.WriteLine();
    Console.WriteLine($"Из данных чисел {nums} больше нуля.");
}