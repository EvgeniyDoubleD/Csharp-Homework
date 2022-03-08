// 61. Найти произведение двух матриц
// Произведением двух матриц будет матрица , элементы которой равны сумме попарных произведений элементов
// строки первой матрицы на соответствующие элементы столбца второй матрицы.
//Из этого следует что перемножить между собой можно матрицы в которых количество столбцов первой равно количеству строк второй
//овая матрица которая является произведением двух имеет размерность , где – количество строк первой матрицы, а – столбцов второй. 
//Правила достаточно просты и для нахождения произведения матриц нужно уметь лиш умножать и прибавлять


int[,] matrixOne = new int[3, 3];
int[,] matrixTwo = new int[3, 3];

void FillAndPrintRArray(int[,] array) // 
{
    Random randomNum = new Random();

    for (int i = 0; i < array.GetLength(0); i++)
    {
        for (int j = 0; j < array.GetLength(1); j++)
        {
            array[i, j] = randomNum.Next(2, 18);
            Console.Write($"[{array[i, j]}]\t");
        }
        Console.WriteLine();
    }
}

void MultiMatrix(int[,] array1, int[,] array2)
{
    for (int i = 0; i < array1.GetLength(0); i++)
    {
        for (int j = 0; j < array2.GetLength(1); j++)
        {
            int result2 = 0;
            for (int k = 0; k < array2.GetLength(1); k++)
            {
                int result = 0;
                result = array1[i, k] * array2[k, j];
                //Console.WriteLine();
                //Console.WriteLine($"result2 = {result} x1 = {i},{k} * x2 = {k},{j}");
                result2 += result;
                //Console.WriteLine($"result2 = {result2}");
            }
            //Console.WriteLine();
            Console.Write($"[{result2}]\t");
        }
        Console.WriteLine();
    }
}

bool CheckArray(int[,] array1, int[,] array2)
{
    int stroka = array1.GetLength(0);
    int stolb = array2.GetLength(1);
    bool b = false;
    if (stroka == stolb)
        b = true;
    return b;
}

bool check = true;
Console.WriteLine("Matrix one:");
FillAndPrintRArray(matrixOne);
Console.WriteLine("=================");
Console.WriteLine("Matrix two:");
FillAndPrintRArray(matrixTwo);
Console.WriteLine("=================");

if (check == CheckArray(matrixOne, matrixTwo))
{
    Console.WriteLine("Result of multiplie:");
    MultiMatrix(matrixOne, matrixTwo);
    Console.WriteLine("=================");
}
else
    Console.WriteLine("Matrix sies is not able to be multiplie!");