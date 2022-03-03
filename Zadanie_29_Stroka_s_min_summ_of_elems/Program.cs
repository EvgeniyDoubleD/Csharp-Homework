// Задача 59: В прямоугольной матрице найти строку с наименьшей суммой элементов.

// Прямоугольная матрица это когда m * n %2 != 0;
// Делаю метод заполнения и демонстрации матрицы
// Делаю метод 

int[,] arr = new int[5, 4];

bool CheckArray(int[,] array)
{
    int stroka = array.GetLength(0);
    int stolb = array.GetLength(1);
    bool b = false;
    if (stroka != stolb)
        b = true;
    return b;
}

void FillAndPrintRArray(int[,] array) // 
{
    Random randomNum = new Random();

    for (int i = 0; i < array.GetLength(0); i++)
    {
        for (int j = 0; j < array.GetLength(1); j++)
        {
            array[i, j] = randomNum.Next(1, 9);
            Console.Write($"[{array[i, j]}]\t");
        }
        Console.WriteLine();
    }
}

int FindMinString(int[,] array)
{
    int minString = 0;
    int summOfstriing = 0;
    for (int i = 0; i < array.GetLength(0); i++)
    {
        int summOfLocalstring = 0;
        for (int j = 0; j < array.GetLength(1); j++)
        {
            summOfLocalstring += array[i, j];
            if (i == 0)
            {
            summOfstriing = summOfLocalstring;
            }
        }

        if (summOfLocalstring < summOfstriing)
        {
            summOfstriing = summOfLocalstring;
            minString = i+1;
        }

        ///Console.WriteLine($"i = {i} minstring = {minString} summOfLocalstring {summOfLocalstring} summofstriing {summOfstriing}");
        Console.WriteLine($"Строка {i+1}, сумма элементов строки - {summOfLocalstring}");
    }

    return minString;
}

bool check = true;
if (check == CheckArray(arr))
{
    FillAndPrintRArray(arr);
    int minString = FindMinString(arr);
    Console.WriteLine($"Строка с наименьшей суммой элементов  - {minString}");
}
else
    Console.WriteLine("Matrix is QUAD!");

// FillAndPrintRArray(arr);
// int minString = FindMinString(arr);

