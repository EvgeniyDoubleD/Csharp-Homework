// Задача 50: В двумерном массиве n×k заменить четные элементы на противоположные.

int[,] arr = new int[5, 5];

void FillAndPrintMinusOddArray(int[,] array) // заполняем массив рандом 1.2 и сразу же его печатаем.
{
    Random rNum = new Random();
    for (int i = 0; i < array.GetLength(0); i++)
    {
        for (int j = 0; j < array.GetLength(1); j++)
        {
            array[i, j] = rNum.Next(10, 111);

            int k = array[i, j];

            if (k % 2 == 0)
            {
                array[i, j] *= -1;
            }

            Console.Write($"[{array[i, j]}]\t");
        }
        Console.WriteLine();
    }
}

FillAndPrintMinusOddArray(arr);

