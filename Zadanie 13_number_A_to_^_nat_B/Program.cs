// Задача 26: Возведите число А в натуральную степень B используя цикл
// вводим число А, вводим число Б - с контролями на дураков (000123 - нули уйдут, отриц числа не допустимы, не натуральные числа не допустимы, текст не допустим, 0 не допустим)
// через цикл с мат.поу возводим пока i != Б 

int GetAnaturalNumber(string msg) // метод ввода числа с проверкой "на дурака"
{
    int number = 0;
    bool result = false;
    string message = null;
    while (result == false || message is null)
    {
        Console.Write(msg);
        string messageIn = Console.ReadLine();
        if (result = int.TryParse(messageIn, out int result_check) && result_check >= 1);
           {
            number = result_check;
            message = messageIn;
           }
    }
    return number;
}

int number = GetAnaturalNumber("Введите натуральное число А: ");
int degree = GetAnaturalNumber("Введите натуральное число B: ");
int i = 0;
int number_in_degree = 1;

while (i != degree)
 {
     number_in_degree *= number;
     i++;
 }

Console.WriteLine($"Число A в степени B  = {number_in_degree}");