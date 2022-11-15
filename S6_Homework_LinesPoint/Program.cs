// Задача 43: Напишите программу, которая найдёт точку пересечения двух прямых, 
// заданных уравнениями y = k1 * x + b1, y = k2 * x + b2; 
// значения b1, k1, b2 и k2 задаются пользователем.
// Например, b1 = 2, k1 = 5, b2 = 4, k2 = 9 -> (-0,5; -0,5).

Console.Clear();
double[] array = new double[4]; // Инициализация массива.
FillArray(array);               // Вызов метода заполнения массива. 
PrintArray(array);              // Вызов метода печати массива. 
double X = CoordX(array);       // Определение координаты Х с использованием метода.
double Y = CoordY(array);       // Определение координаты Y c использованием метода. 
Console.WriteLine();            // Отступ и вывод итогового сообщения. 
Console.WriteLine($"Две прямые пересекаются в точке с координатами: ({X}; {Y}).");

void FillArray(double[] array)             // Метод заполнения массива. 
{
    Console.Write("Введите числа в следующем порядке: k1, b1, k2, b2.");
    Console.WriteLine();
    for (int i = 0; i < array.Length; i++) // Условия выхода из цикла. 
    {                                      
        Console.Write("Введите число: ");  // Значения, введенные пользователем, 
        array[i] = double.Parse(Console.ReadLine()!); // помещаются в соответствующие элементы массива.
    }
}
void PrintArray(double[] array)            // Метод вывода массива на печать.
{
    Console.Clear();                   
    Console.Write("Введены следующие значения: [ ");                  
    for (int i = 0; i < array.Length; i++) 
    {
        Console.Write(array[i] + " ");     
    }
    Console.Write("]");                    
}

double CoordX(double[] col)                // Метод расчета координаты Х.
{
    double X = (col[3] - col[1]) / (col[0] - col[2]);
    return X;
}

double CoordY(double[] col)                // Метод расчета координаты Y.
{
    double Y = col[0] * (col[3] - col[1]) / (col[0] - col[2]) + col[1];
    return Y;
}

// ВАРИАНТ БЕЗ МЕТОДОВ - очень простой.

// Console.Clear();
// Console.Write("Введите значение k1: ");
// double k1 = double.Parse(Console.ReadLine()!);
// Console.Write("Введите значение b1: ");
// double b1 = double.Parse(Console.ReadLine()!);
// Console.Write("Введите значение k2: ");
// double k2 = double.Parse(Console.ReadLine()!);
// Console.Write("Введите значение b2: ");
// double b2 = double.Parse(Console.ReadLine()!);
// double X = (b2 - b1) / (k1 - k2);
// double Y = k1 * (b2 - b1) / (k1 - k2) + b1;
// Console.WriteLine($"Две прямые пересекаются в точке с координатами: ({X}; {Y}).");