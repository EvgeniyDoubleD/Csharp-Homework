﻿// Задача 48: Показать двумерный массив размером m×n заполненный целыми числами.

int [,] arr = new int[5,5];

void FillAndPrintArray(int[,] array) // заполняем массив рандом 1.2 и сразу же его печатаем.
{
    Random rNum = new Random();
    for (int i = 0; i < array.GetLength(0); i++)
    {
        for (int j = 0; j < array.GetLength(1); j++)
        {
            array[i, j] = rNum.Next(0, 2);
            Console.Write($"[ {array[i, j]} ]");
        }
        Console.WriteLine();
    }
}

FillAndPrintArray(arr);
