// Задача 32: Задать массив из 8 элементов, заполненных нулями и единицами вывести их на экран
// 1. Создаем массив на 8 элементов, сразу, поскольку в задаче указано :) 
// 2. Заполняем массив через рандом, в целом задача не оч сложная..

void FillArray(int [] array)
{
    Random rNum = new Random();
    for ( int i = 0; i != array.Length; i++)
        array [i] = rNum.Next(0,2);
        

}
void PrintArray(int [] array) // Выводим массив N^ = 
{
    for ( int i = 0; i != array.Length; i++)
        Console.Write($"[ {array[i]} ]");
}

int [] array = new int[8];
FillArray(array);
PrintArray(array);