// Напишите программу, которая выводит массив из 8 элементов, заполненный нулями 
// и единицами в случайном порядке. Например, [0, 1, 1, 0, 1, 0, 1, 0].
Console.Clear();                   // Отчистим консоль. 
int [] array = new int[8];         // Создадим массив, имеющий 8 элементов. 
FillArray(array);                  // Вызовем метод заполнения массива.
PrintArray(array);                 // Вызовем метод вывода массива на печать. 

void FillArray(int [] collection)  // Опишем метод заполнения массива. 
{
    int length = collection.Length;                  // Установим длину массива. 
    for(int index = 0; index<length; index++)        // Зададим условия цикла. 
    {
        collection[index] = new Random().Next(0, 2); // Сгенерируем цифры 0 и 1.
    }
}
void PrintArray(int [] collection)  // Опишем метод вывода массива на печать.          
{
    int count = collection.Length;                   // Установим длину массива.
    for(int index = 0; index<count; index++)         // Зададим условия цикла. 
    {
        Console.Write($"{collection[index]} ");      // Выведем на печать массив. 
    }
}
