// 61. Найти произведение двух матриц
// Произведением двух матриц будет матрица , элементы которой равны сумме попарных произведений элементов
// строки первой матрицы на соответствующие элементы столбца второй матрицы.
//Из этого следует что перемножить между собой можно матрицы в которых количество столбцов первой равно количеству строк второй
//овая матрица которая является произведением двух имеет размерность , где – количество строк первой матрицы, а – столбцов второй. 
//Правила достаточно просты и для нахождения произведения матриц нужно уметь лиш умножать и прибавлять


int[,] matrixOne = new int[2, 2];
int[,] matrixTwo = new int[2, 2];

void FillAndPrintRArray(int[,] array) // 
{
    Random randomNum = new Random();

    for (int i = 0; i < array.GetLength(0); i++)
    {
        for (int j = 0; j < array.GetLength(1); j++)
        {
            array[i, j] = randomNum.Next(2, 4);
            Console.Write($"[{array[i, j]}]\t");
        }
        Console.WriteLine();
    }
}

int [,] MultiMaxtix(int[,] array1, int[,] array2)
{
    int [,] array3 = new int [array1.GetLength(0), array2.GetLength(1)];
    for (int i = 0; i < array1.GetLength(0); i++)
    {
        for (int j = 0; j < array2.GetLength(1); j++)
        {
            array3 [i,j] = 0;
            for (int k = 0; k < array2.GetLength(1); k++)
            {
                array3[i,j] += array1[i, k] * array2[k, j];
                // int result = 0;
                // result = array1[i, k] * array2[k, j];
                // Console.WriteLine();
                // Console.WriteLine($"result2 = {result} x1 = {i},{k} * x2 = {k},{j}");
                // result2 += result;
                // Console.WriteLine($"result2 = {result2}");
                // for (int t = 0; t < array1.GetLength(1); t++)
                // {

                // }
            }
            // Console.WriteLine();
            // Console.Write($"[{result2}]\t");
        }
        // Console.WriteLine();
    }
    return array3;
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

FillAndPrintRArray(matrixOne);
Console.WriteLine("=======");
FillAndPrintRArray(matrixTwo);
Console.WriteLine("=======");
Console.WriteLine("resultmatrix:");
var matrix = MultiMaxtix(matrixOne, matrixTwo);
PrintRArray(matrix);