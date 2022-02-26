// See Задача 52: В двумерном массиве заменить элементы, у которых оба индекса чётные на их квадраты.

int[,] arr = new int[6, 6];

void FillAndPrintMinusOddArray(int[,] array) // заполняем и сразу возводим в квадрат. 
{
    Random rNum = new Random();
    for (int i = 0; i < array.GetLength(0); i++)
    {
        for (int j = 0; j < array.GetLength(1); j++)
        {
            array[i, j] = rNum.Next(04, 05);
            int c = array[i, j] * array[i, j];

            if (i % 2 == 0 && j % 2 == 0) // || (i+j == 0)
            {
                array[i, j] = c;
            }

            Console.Write($"[{array[i, j]}]\t");
        }
        Console.WriteLine();
    }
}

FillAndPrintMinusOddArray(arr);

