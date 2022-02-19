// Задача 40: В Указанном массиве вещественных чисел найдите разницу между максимальным и минимальным элементом.
// создаем массив вещественных чисел (тип дабл?);
// создаем min/max переменные, пробегаемся по массиву, запоминаем мин-макс
// макс минус мин - на печать.

void FillAndPrintArray(double [] array) // заполняем массив рандом вещественными числами и его выводим в терминал;
{
    Random rNum = new Random();
    for ( int i = 0; i != array.Length; i++)
        {
        array [i] = Math.Round(rNum.NextDouble() * 5, 2);
        Console.Write($"[{array[i]:N2}]\t");
        }
}

void DifferenceOfMaxMinElements(double [] array) // находим разницу макс-мин эл-тов массива, выводим в консоль
{
    double maxElem = array[0];
    double minElem = array[0];
    for (int i = 0; i != array.Length; i++)
        {
            if (array[i] > maxElem)
                maxElem = array[i];
            else if (array[i] < minElem)
                minElem = array[i];
        }
    double differenceMaxMin = Math.Round((maxElem - minElem),2);
    Console.WriteLine($"Max эл-т массива: {maxElem:N2} \nMin эл-т массива: {minElem:N2} \nРазница (Max - Min) составляет: {differenceMaxMin:N2}");
}

void FineBreakOnConsole(string msg) // красиво разделяем вывод в терминал
{
    Console.WriteLine(msg);
}

double [] array = new double [5];

FineBreakOnConsole("Сгенерирован массив:");
FillAndPrintArray(array);
FineBreakOnConsole("");
DifferenceOfMaxMinElements(array);