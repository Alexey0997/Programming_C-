// Задача 45: Напишите программу, которая будет создавать копию заданного массива 
// с помощью поэлементного копирования.

Console.Clear();
Console.WriteLine("Введите размер массива: ");    // Запрос пользователя. 
int arrayLength = int.Parse(Console.ReadLine()!); // Ввод переменной - длины массива. 
int[] array = new int[arrayLength];               // Инициализация исходного массива. 
int[] copy = new int[arrayLength];                // Инициализация массива-копии. 
FillArray(array, 10);                             // Вызов метода заполнения массива. 
CopyArray(array, copy);                           // Вызов метода копирования массива. 
Console.Clear();                                 

Console.WriteLine("Исходный массив:");            // Начало первого сообщения.
PrintArray(array);                                // Печать исходного массива. 
Console.WriteLine();                              // Пустая строка. 
Console.WriteLine("Копия исходного массива:");    // Начало второго сообщения.
PrintArray(copy);                                 // Печать массива-копии. 

void FillArray(int[] fillArr, int diviation)      // Метод заполнения массива. 
{
    for (int i = 0; i < fillArr.Length; i++)      // Условия цикла. 
    {
        fillArr[i] = new Random().Next(-diviation, diviation + 1); // Генератор случайных чисел. 
    }
}

void CopyArray(int[] copyArr, int[] fillArr)      // Метод копирования массива. 
{
    for (int i = 0; i < copyArr.Length; i++)      // Условия цикла.
    {
        fillArr[i] = copyArr[i];                  // Каждый элемент исходного массива равен 
    }                                             // соответствующему элементу копии. 
}

void PrintArray(int[] printArray)                 // Метод вывода на печать. 
{
    Console.Write("[ ");                          // Открывающая скобка. 
    for (int i = 0; i < printArray.Length; i++)   // Условия выхода из цикла. 
    {
        Console.Write($"{printArray[i]} ");       // Печать элементов массива.
    }
    Console.WriteLine("]");                       // Закрывающая скобка. 
}