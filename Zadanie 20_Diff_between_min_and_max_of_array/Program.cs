// Задача 40: В Указанном массиве вещественных чисел найдите разницу между максимальным и минимальным элементом.
// создаем массив вещественных чисел (тип дабл?);
// создаем min/max переменные, пробегаемся по массиву, запоминаем мин-макс
// макс минус мин - на печать.

int GetAMassiveSize(string msg) // метод ввода числа с проверкой
{
    int number = 0;
    bool result = false;
    while (result == false)
    {
        Console.Write(msg);
        string messageIn = Console.ReadLine();
        if (result = int.TryParse(messageIn, out int result_check) && result_check > 1);
           {
            number = result_check;
           }
    }
    return number;
}

void FillAndPrintArray(double [] array) // заполняем массив рандом вещественными числами и его выводим в терминал;
{
    Random rNum = new Random();
    for ( int i = 0; i != array.Length; i++)
        {
            array [i] = Math.Round(rNum.NextDouble() * 15, 2);
            Console.Write($"[{array[i]:N2}] ");
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

int massiveSize = GetAMassiveSize("Укажите желаемый размер массива: ");

double [] array = new double [massiveSize];

FineBreakOnConsole($"Сгенерирован массив из {massiveSize} элементов: ");

FillAndPrintArray(array);

FineBreakOnConsole("");

DifferenceOfMaxMinElements(array);