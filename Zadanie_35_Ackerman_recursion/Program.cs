// Напишите программу вычисления функции Аккермана с помощью рекурсии. Даны два неотрицательных числа m и n.
// m = 2, n = 3 -> A(m,n) = 29

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

int AckermanTry(int numM, int numN)
{
    if (numM == 0)
        return numN + 1;
    else if (numN == 0)
        return AckermanTry(numM - 1, 1);
    else
        return AckermanTry(numM - 1, AckermanTry(numM, numN - 1));

}

int m = GetAnaturalNumber("Введите натуральное число M: ");
int n = GetAnaturalNumber("Введите натуральное число N: ");

int ackerman = AckermanTry(m, n);

Console.WriteLine($"Ackerman function = {ackerman}");