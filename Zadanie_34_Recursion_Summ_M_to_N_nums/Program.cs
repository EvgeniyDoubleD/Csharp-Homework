// Задача 69: Задайте значения M и N. Напишите программу, которая найдёт сумму натуральных элементов в промежутке от M до N.
// Задаем M и N , делаем счетчик который себя крутит и выводим.

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

void FirstRecursionTry(int numA, int numB, int summ)
{
    if (numA != numB)
    {
        summ++;
        numA++;
        FirstRecursionTry(numA, numB, summ);
    }
    else
    {   
        summ++;
        Console.Write($"Summ of natural elems = {summ}");
    }
        
}

int m = GetAnaturalNumber("Введите натуральное число M: ");
int n = GetAnaturalNumber("Введите натуральное число N: ");

if (m < n)
{
    FirstRecursionTry(m, n, 0);
}
else
    FirstRecursionTry(n, m, 0);
