// See Задача 38: Найти сумму чисел одномерного массива стоящих на нечетной позиции.
// задаем массив N размера
// заполняем его рандом значениями
// создаем переменную накопитель, в которую складываем сумму элементов стоящих на нечтеном индексе выводим

void FillAndPrintArray(int [] array) // заполняем массив рандом значениями и сразу же его выводим в терминал;
{
    Random rNum = new Random();
    for ( int i = 0; i != array.Length; i++)
        {
        array [i] = rNum.Next(1,15);
        Console.Write($"[{array[i]}]\t");
        }
}

void SummOfOddIndexElems(int [] array) // считаем сумму эл-тов на нечетной позиции
{
    int summOdd = 0;
    for (int i = 0; i != array.Length; i++)
        {
            if ((i+1)%2 != 0)
                summOdd += array[i];
        }
    Console.WriteLine($"Cумма чисел стоящих на не четной позиции массива: {summOdd}");
}

void FineBreakOnConsole(string msg) // красиво разделяем вывод в терминал
{
    Console.WriteLine(msg);
}

int [] array = new int [9];

FineBreakOnConsole("Сгенерирован массив:");
FillAndPrintArray(array);
FineBreakOnConsole("");
SummOfOddIndexElems(array);