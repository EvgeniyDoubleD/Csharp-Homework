// Задача 63: Сформировать трехмерный массив не повторяющимися двузначными числами показать его построчно на экран выводя индексы соответствующего элемента
//

int[,,] threedmassive = new int[3, 3, 3];

void FillAndPrintRArray(int[,,] array) // 
{
    int mNum = 10;

    for (int i = 0; i < array.GetLength(0); i++)
    {
        for (int j = 0; j < array.GetLength(1); j++)
        {
            for (int k = 0; k < array.GetLength(2); k++)
            {
                array[i, j, k] = mNum;
                Console.Write($"[{i},{j},{k}] {array[i, j, k]}\t");
                mNum++;
            }
            Console.WriteLine();
        }
        Console.WriteLine("==========================================");
    }
}

Console.WriteLine("3d massive printout: ");
FillAndPrintRArray(threedmassive);