// See Задача 57: Написать программу, которая упорядочивает по убыванию элементы каждой строки двумерной массива.

int[,] arr = new int[8, 15];

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

void SortArray(int[,] array)
{
    for (int i = 0; i < array.GetLength(0); i++)
    {
        for (int j = 0; j < array.GetLength(1) - 1; j++)
        {
            int maxNumb = array[i, j];
            if (maxNumb < array[i, j + 1])
            {
                maxNumb = array[i, j + 1];
                array[i, j + 1] = array[i, j];
                array[i, j] = maxNumb;
                // Console.WriteLine("NACHALO CIKLA");
                // Console.WriteLine("-----------");
                // Console.WriteLine($" stroka = {i} ; stolbec =  {j} ; maxnumb = {maxNumb} transfer - {array[i, j + 1]} <--> {array[i, j]}");
            }
        }
    }
}

void PrintArray(int[,] array)
{
    for (int i = 0; i < array.GetLength(1); i++)
        SortArray(arr);
    for (int i = 0; i < array.GetLength(0); i++)
    {
        for (int j = 0; j < array.GetLength(1); j++)
        {
            Console.Write($"[{array[i, j]}]\t");
        }
        Console.WriteLine();
    }
}


MainMatrixSumm(arr);
Console.WriteLine("========");
PrintArray(arr);



// array[i, j] = c;
// Console.Write($"[{array[i, j]}]\t");
// c++;