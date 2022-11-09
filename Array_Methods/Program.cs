// Типовые задачи работы с массивами. 
Console.Clear();
int [] array = new int [20];  // Создадим массив размером 8 элементов.
FillArray(array);             // Используем метод заполнения массива.
PrintArray(array);            // Метод вывода на печать.
TurnArray(array);             // Метод разворота массива.
Console.WriteLine();          // Запись с новой строчки.
PrintArray(array);            // Метод вывода на печать.
Console.WriteLine();          // Запись с новой строчки.
Console.WriteLine();          // Пустая строка. 
SortArray(array);             // Сортировка элементов массива. 
PrintArray(array);            // Метод вывода на печать.

// ЗАПОЛНЕНИЕ МАССИВА

void FillArray(int [] col)    // Заполним массив с помощью генератора сл. чисел. 
{
    for(int i = 0; i < col.Length; i++)     // Зададим условия цикла.
    {
        col[i] = new Random().Next(0, 51); // Заполним цифрами от 0 до 5.
    }
}

/*void FillArray(int [] col)     // Заполним массив данными пользователя. 
{
    for(int i = 0; i < col.Length; i++)               // Зададим условия цикла. 
    {
        Console.WriteLine("Введите число массива: "); // Предложим 8 раз ввести число.
        col [i] = int.Parse(Console.ReadLine()!);     // В ячейки положим введ. цифры.
    }
}*/

// ПЕЧАТЬ МАССИВА

void PrintArray(int [] col)   // Выведем массив на печать. 
{
    for(int i = 0; i < col.Length; i++)     // Определим условия цикла. 
    {
        Console.Write($"{col[i]} ");        // Напечатаем каждый элемент массива. 
    }
}

// РАЗВОРОТ МАССИВА
void TurnArray(int [] col)
{
    int i = 0;
    while(i < col.Length/2)
    {
        int temp = col[i];
        col[i] = col[col.Length-1-i];
        col[col.Length-1-i] = temp;
        i++;
    }
}

// СОРТИРОВКА МАССИВА ПО УБЫВАНИЮ

void SortArray(int [] col)
{
    for(int i = 0; i < col.Length; i++)
    {
        int maxPosition = i;
        for(int j = i+1; j < col.Length; j++)
        {
            if(col[j] > col[maxPosition]) maxPosition = j;
        }
        int temp = col[i];
        col[i] = col[maxPosition];
        col[maxPosition] = temp;
    }
}

// ОПРЕДЕЛЕНИЕ ДНЯ НЕДЕЛИ
// Задача 15: напишите программу, которая принимает на вход цифру, обозначающую день недели,
// и проверяет, является ли этот день выходным. 
/*Console.Clear();
int [] week = {1, 2, 3, 4, 5, 6, 7};
Console.WriteLine($"Уважаемый пользователь, введите число, обозначающее день недли, от {1} до {7}: ");
int day = int.Parse(Console.ReadLine());
int n = week.Length;           // Запрос данных о размере массива.
int find = day;                // Искомое число day - номер дня недели.
int index = 0;                 // Начать исследование с нулевого элемента массива. 
while(index < n)               // Цикл проверки элементов массива. 
{
    if(week[index] == find)    
        if(index > 4)          // Если заданное число в ячейках 5 или 6, то это выходной. 
        {
            Console.WriteLine($"День недели с номером {day} является выходным."); 
        }
        else                   // Если искомое число в ячейках (0, 4) - рабочий день. 
        {
            Console.WriteLine($"День недели с номером {day} не является выходным.");
            break;             // Остановить проверку при первом совпадении чисел. 
        }
index++;                       // Перейти к проверке следующего элемента массива. 
}*/

