// 30. Показать кубы чисел, заканчивающихся на четную цифру
// формируем "случайный" массив из чисел которые заканчиваются на четную цифру
// возводим в кубы 
// выводим на печать?

int numberR = new Random().Next(1,55);
Console.WriteLine($"Сгенерировано число: {numberR}");

int [] array = new int[numberR];
int [] FillArray(int [] array) // Заполняем массив кубами N
{
    for ( int i = 0; i < array.Length; i++)
        if ((i+1)%2 == 0)
            array[i] = (int)Math.Pow((i+1),3);
            return array;
}

void PrintArray(int [] array) // Выводим массив N^ = 
{
    Console.WriteLine("Число Значение");
    for ( int i = 0; i != array.Length; i++)
        if (array[i] != 0)
        Console.WriteLine($"{i+1}^3 = {array[i]}");
}

int [] arrays = FillArray(array);

PrintArray(arrays);