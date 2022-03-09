// Задача 65: Спирально заполнить двумерный массив


int[,] spiralityArray = new int[5, 5];

void FillArray(int[,] array) // 
{
    int maxRows = array.GetLength(0) - 1; //+
    int maxColumn = array.GetLength(1) - 1; //+
    int numb = 1; //++
    int maxNumb = array.GetLength(0) * array.GetLength(1); //+
    int currentRow = 0; // +
    int currentColumn = 0; //+ 

    while (numb != maxNumb)
    {
        for (int i = currentColumn; i <= maxColumn; i++)
        {
            array[currentRow, i] = numb;
            numb++;
        }
        currentRow++;
        for (int i = currentRow; i <= maxRows; i++)
        {
            array[i, maxColumn] = numb;
            numb++;
        }
        maxColumn--;
        for (int i = maxColumn; i >= currentColumn; i--)
        {
            array[maxRows, i] = numb;
            numb++;
        }
        maxRows--;
        for (int i = maxRows; i >= currentRow; i--)
        {
            array[i, currentColumn] = numb;
            numb++;
        }
        currentColumn++;

        if (currentColumn == currentRow)
            array[currentRow, currentColumn] = numb;
    }
}

void PrintRArray(int[,] array) // 
{

    for (int i = 0; i < array.GetLength(0); i++)
    {
        for (int j = 0; j < array.GetLength(1); j++)
        {
            Console.Write($"[{array[i, j]}]\t");
        }
        Console.WriteLine();
    }
}

FillArray(spiralityArray);
PrintRArray(spiralityArray);