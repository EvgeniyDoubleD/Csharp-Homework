// Задача 36: Задать массив, заполнить случайными положительными трёхзначными числами. Показать количество нечетных\четных чисел.

// создаем массив размер указываем сами
// заполняем массив случайными числами от 100 до 1000 
// 1 переменна счетчика, с условием %2 получаем четные, из длинны массива вычитаем счетчик получаем нечетные.
// выводим на печать массив к ознакомлению, и счетчики положит/отриц

void FillAndPrintArray(int [] array) // заполняем массив рандом значениями и сразу же его выводим в терминал;
{
    Random rNum = new Random();
    for ( int i = 0; i != array.Length; i++)
        {
        array [i] = rNum.Next(100,1000);
        Console.Write($"[{array[i]}]");
        }
}

void CountEvenAndOddArray(int [] array) // считаем четные - нечетные эл-ты, выводим результат
{
    int even = 0;
    int odd = 0;
    for (int i = 0; i != array.Length; i++)
        {
            if (array[i]%2 == 0)
                even++;
        }
    odd = array.Length - even;
    Console.WriteLine($"Четных элементов в массиве: {even} \nНечетных элементов в массив: {odd}");
}

void FineBreakOnConsole(string msg) // красиво разделяем вывод в терминал
{
    Console.WriteLine(msg);
}

int [] array = new int [21];

FineBreakOnConsole("Сгенерирован массив: ");
FillAndPrintArray(array);
FineBreakOnConsole("");
CountEvenAndOddArray(array);