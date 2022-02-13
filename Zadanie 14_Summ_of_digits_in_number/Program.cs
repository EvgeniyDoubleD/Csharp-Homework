// Задача 28: Подсчитать сумму цифр в числе
// 1. Пользователь вводит число, можно положительное можно отрицательное (это я так решил нам ведь требуется посчитать сумму цифр, без контекста числа),
// проверка на буквы/0/пустые строки/ числа с запятой (только целые берем)
// 2. Решение придумал такое - суммируем остаток от деления числа на 10, само число также делим на 10, потом складываем в эту же переменную сумму остаков от деления с числом оставшимся.
// вы великолепны.))) 

int GetANumber(string msg) // метод ввода точки координат с проверкой "на дурака"
{
    int number = 0;
    bool result = false;
    while (result == false)
    {
        Console.Write(msg);
        string messageIn = Console.ReadLine();
        if (result = int.TryParse(messageIn, out int result_check) && result_check != 0);
           {
            number = Math.Abs(result_check);
           }
    }
    return number;
}

int number = GetANumber("Введите целое число сумму цифр которого необходимо посчитать: ");

int i = 10;
int summ = 0;

while (i < number)
    {
        summ += number%10;
        number /= 10;
    }
summ = summ + number;

Console.WriteLine($"Сумма цифр числа составляет - {summ}");