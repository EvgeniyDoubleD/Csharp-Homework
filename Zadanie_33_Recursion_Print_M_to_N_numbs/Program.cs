// Задайте значения M и N. Напишите программу, которая выведет все натуральные числа в промежутке от M до N.
// 1. Пользователь задает M и N с проверкой на дурака (натуральные числа)
// 2. Рекурсивный метод выводит M потом делаеть M+1 и дальше в себя крутит.

int GetAnaturalNumber(string msg) // метод ввода числа с проверкой "на дурака"
{
    int number = 0;
    bool result = false;
    string message = null;
    while (result == false || message is null)
    {
        Console.Write(msg);
        string messageIn = Console.ReadLine();
        if (result = int.TryParse(messageIn, out int result_check) && result_check >= 1) ;
        {
            number = result_check;
            message = messageIn;
        }
    }
    return number;
}

void FirstRecursionTry(int numA, int numB)
{
    if (numA != numB)
    {
        Console.Write($"{numA}, ");
        numA++;
        FirstRecursionTry(numA, numB);
    }
    else
        Console.Write(numB);
}

int m = GetAnaturalNumber("Введите натуральное число M: ");
int n = GetAnaturalNumber("Введите натуральное число N: ");

if (m < n)
{
    FirstRecursionTry(m, n);
}
else
    FirstRecursionTry(n, m);
