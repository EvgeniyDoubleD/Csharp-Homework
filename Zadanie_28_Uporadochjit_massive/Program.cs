// See Задача 57: Написать программу, которая упорядочивает по убыванию элементы каждой строки двумерной массива.

int[,] arr = new int[4, 4];

void MainMatrixSumm(int[,] array) // 
{
    int c = 1;
    int s = array.GetLength(0);
    for (int i = 0; i < array.GetLength(0); i++)
    {
        for (int j = 0; j < array.GetLength(1); j++)
        {
            array[i, j] = c;
            Console.Write($"[{array[i, j]}]\t");
            c++;
        }
        Console.WriteLine();
    }


}



MainMatrixSumm(arr);