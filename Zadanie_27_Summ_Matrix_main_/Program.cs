// Задача 54: В матрице чисел найти сумму элементов главной диагонали.
int[,] arr = new int[4, 4];

void MainMatrixSumm(int[,] array) // 
{
    int c = 0;
    for (int i = 0; i < array.GetLength(0); i++)
    {
        for (int j = 0; j < array.GetLength(1); j++)
        {
            array[i, j] = 0;

            if (i == j) // || (i+j == 0)
            {
                array[i,j] = 1;
                c += array[i, j];
            }

            Console.Write($"[{array[i, j]}]\t");
        }
        Console.WriteLine();
    }
    Console.WriteLine($"Сумма главной диагонали  = {c}");
}



MainMatrixSumm(arr);