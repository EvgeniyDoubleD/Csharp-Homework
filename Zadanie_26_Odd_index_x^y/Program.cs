// See Задача 52: В двумерном массиве заменить элементы, у которых оба индекса чётные на их квадраты.

int[,] arr = new int[15, 15];

void FillAndPrintMinusOddArray(int[,] array) // заполняем массив рандом 1.2 и сразу же его печатаем.
{
    Random rNum = new Random();
    for (int i = 0; i < array.GetLength(0); i++)
    {
        for (int j = 0; j < array.GetLength(1); j++)
        {
            array[i, j] = rNum.Next(04, 05);

            int k = i ;
            int b = j ;
            int c = array[i, j] * array[i, j];

            if (k % 2 == 0 && b % 2 == 0) // || (i+j == 0)
            {
                array[i, j] = c;
            }

            Console.Write($"[{array[i, j]}]\t");
        }
        Console.WriteLine();
    }
}

FillAndPrintMinusOddArray(arr);

