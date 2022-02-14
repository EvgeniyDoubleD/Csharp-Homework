// Задача 32: Задать массив из 8 элементов, заполненных нулями и единицами вывести их на экран
// 1. Создаем массив на 8 элементов, сразу, поскольку в задаче указано :) 
// 2. Заполняем массив через рандом, в целом задача не оч сложная..

void FillAndPrintArray(int [] array) // заполняем массив рандом 1.2 и сразу же его печатаем.
{
    Random rNum = new Random();
    for ( int i = 0; i != array.Length; i++)
        {
        array [i] = rNum.Next(0,2);
        Console.Write($"[ {array[i]} ]");
        }
}


int [] array = new int[8];
FillAndPrintArray(array);
