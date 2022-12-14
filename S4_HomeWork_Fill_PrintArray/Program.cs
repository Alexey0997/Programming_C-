// Задача 29: Напишите программу, которая задаёт массив из 8 элементов 
// и выводит их на экран. Например, 1, 2, 5, 7, 19 -> [1, 2, 5, 7, 19].
Console.Clear();                   // Отчистим консоль. 
int [] array = new int[8];         // Создадим массив, имеющий 8 элементов. 
FillArray(array);                  // Вызовем метод заполнения массива.
PrintArray(array);                 // Вызовем метод вывода массива на печать. 

void FillArray(int [] col)     // Опишем метод заполнения массива с генерацией чисел. 
{
    for(int i = 0; i<col.Length; i++)         // Зададим условия цикла. 
    {
        col[i] = new Random().Next(0, 51);    // Сгенерируем цифры от 0 до 50.
    }
}
void PrintArray(int [] col)    // Опишем метод вывода массива на печать.          
{
    for(int i = 0; i<col.Length; i++)         // Зададим условия цикла. 
    {
        Console.Write($"{col[i]} ");          // Выведем на печать массив. 
    }
}