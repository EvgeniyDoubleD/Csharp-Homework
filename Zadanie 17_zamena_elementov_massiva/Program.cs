// Задача 34: Написать программу замену элементов массива на противоположные.

// создаем массив, заполняем рандомными числами
// создаем переменную контейнер где умножаем  i эл-т массива на -1
// присваиваем i индексу значение из контейнера

void FineBreakOnConsole(string msg) // красиво разделяем вывод в терминал
{
    Console.WriteLine(msg);
}
void FillAndPrintArray(int [] array) // заполняем массив рандом значениями и сразу же его выводим в терминал;
{
    Random rNum = new Random();
    for ( int i = 0; i != array.Length; i++)
        {
        array [i] = rNum.Next(-14,14);
        Console.Write($"[{array[i]}]\t");
        }
}

void ChangeArrayElements(int [] array) // меняем элементы массива на противоположные;
{
    int container = 0;
    for (int i = 0; i != array.Length; i++)
    {
        container = array[i] * -1;
        array [i] = container;
        Console.Write($"[{array[i]}]\t");
    }
}

int [] array = new int [9];

FineBreakOnConsole("Сгенерирован массив:");

FillAndPrintArray(array);

FineBreakOnConsole("");

FineBreakOnConsole("Сгенерирована замена элементов массива:");

ChangeArrayElements(array);
