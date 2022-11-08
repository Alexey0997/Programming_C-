// // Задача 29: Напишите программу, которая задаёт массив из 8 элементов 
// и выводит их на экран. Например, 1, 2, 5, 7, 19 -> [1, 2, 5, 7, 19].
Console.Clear();                   // Отчистим консоль. 
int [] array = new int[8];         // Создадим массив, имеющий 8 элементов. 
FillArray(array);                  // Вызовем метод заполнения массива.
PrintArray(array);                 // Вызовем метод вывода массива на печать. 

void FillArray(int [] col)     // Опишем метод заполнения массива пользователем. 
{
Console.WriteLine("Введите первое число массива: ");
int i0 = int.Parse(Console.ReadLine()!);
array[0] = i0;
Console.WriteLine("Введите второе число массива: ");
int i1 = int.Parse(Console.ReadLine()!);
array[1] = i1;
Console.WriteLine("Введите третье число массива: ");
int i2 = int.Parse(Console.ReadLine()!);
array[2] = i2;
Console.WriteLine("Введите четвертое число массива: ");
int i3 = int.Parse(Console.ReadLine()!);
array[3] = i3;
Console.WriteLine("Введите пятое число массива: ");
int i4 = int.Parse(Console.ReadLine()!);
array[4] = i4;
Console.WriteLine("Введите шестое число массива: ");
int i5 = int.Parse(Console.ReadLine()!);
array[5] = i5;
Console.WriteLine("Введите седьмое число массива: ");
int i6 = int.Parse(Console.ReadLine()!);
array[6] = i6;
Console.WriteLine("Введите восьмое число массива: ");
int i7 = int.Parse(Console.ReadLine()!);
array[7] = i7;
}
void PrintArray(int [] col)    // Опишем метод вывода массива на печать.          
{
    int count = col.Length;                   // Установим длину массива.
    for(int i = 0; i<count; i++)              // Зададим условия цикла. 
    {
        Console.Write($"{col[i]} ");          // Выведем на печать массив. 
    }
}