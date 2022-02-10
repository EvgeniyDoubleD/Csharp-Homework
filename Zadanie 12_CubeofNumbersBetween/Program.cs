// Задача 24: Найти кубы чисел от 1 до N , 
// число N будет рандомное от 1 до 25.
// 1. Генерируем случайное число
// 2. Создаем массив.
// 3. Заполняем массив кубами 
// 4. Печатаем массив.

int GetRandomNumber(string message)
{
    int numberR = new Random().Next(1,26);
    Console.WriteLine($"Сгенерировано число: {numberR}");
    return numberR;
}

int [] InitArray(int number)
{
    int [] Array = new int[number];
    return Array;
}

int [] FillArray(int [] array)
{
    for ( int i = 0; i < array.Length; i++)
        array[i] = (int)Math.Pow((i+1),3);
        return array;

}

void PrintArray(int [] array)
{
    Console.WriteLine("Число Значение");
    for ( int i = 0; i != array.Length; i++)
        Console.WriteLine($"{i+1}^3 = {array[i]}");

}

int rNumber = GetRandomNumber("RandomN Number Gen");

int [] array = InitArray(rNumber);

int [] fArray = FillArray(array);

PrintArray(fArray);