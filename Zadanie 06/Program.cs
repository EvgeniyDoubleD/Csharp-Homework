// Задача 12: Удалить вторую цифру трёхзначного числа.
int RemoveSecondDigit(int number)
{
    return number = ((number /100)*10) + (number % 10);
    
}

int GetRightInteger(int min, int max)
{
    int result = 0;
    bool isWrong = true;
    while (isWrong)
    {
        Console.Write($"Введите трехзначное натуральное число с {min} по {max}: ");
        string number = Console.ReadLine();
        result = int.Parse(number);
        isWrong = result < min || result > max;
    }
    return result; 

}

int numberToGet = GetRightInteger(100,999);

// Console.Write ("Введите трехзначное натруальное число: ");

// string number = Console.ReadLine();

// int numberToGet = int.Parse(number);

int secDig = RemoveSecondDigit(numberToGet);

Console.Write($"Вторая цифра заданного числа удалена, новое число = {secDig}");
