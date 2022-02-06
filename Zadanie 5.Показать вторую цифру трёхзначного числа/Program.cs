// Задача 10: Показать вторую цифру трёхзначного числа.
int GetSecondDigit(int number)
{
    return number = number % 100 / 10;
    
}

Console.Write ("Введите трехзначное натруальное число: ");

string number = Console.ReadLine();

int numberToGet = int.Parse(number);

int secDig = GetSecondDigit(numberToGet);

Console.Write($"Вторая цифла заданного числа = {secDig}");
