// Найти точку пересечения двух прямых заданных уравнением y = k1 * x + b1, y = k2 * x + b2    b1 k1 и b2 и k2 заданы -
// кем заданы k и b я так и не понял, поэтому у меня будут заданы пользователем.
// сперва надо решить систему уравнений  приравняем уравнения:
// K1x+b1=K2x+b2 -> K1x-K2x=b2-b1 -> x = (b2-b1)/(K1-K2)

double GetANumber(string msg) // метод ввода числа с проверкой "на дурака"
{
    double number = 0;
    bool result = false;
    string message = null;
    while (result == false || message is null)
    {
        Console.Write(msg);
        string messageIn = Console.ReadLine();
        if (result = double.TryParse(messageIn, out double result_check)) ;
        {
            number = result_check;
            message = messageIn;
        }
    }
    return number;
}
Console.WriteLine("Найти точку пересечения двух прямых заданных уравнением y = k1 * x + b1, y = k2 * x + b2 ");

double b1 = GetANumber("Введите переменную b1: ");
double k1 = GetANumber("Введите переменную k1: ");
double b2 = GetANumber("Введите переменную b2: ");
double k2 = GetANumber("Введите переменную k2: ");

double x = (b2 - b1) / (k1 - k2);
double y = (k2 * x) + b2;

if (k1 == k2)
    Console.WriteLine("Прямые не пересекаются");
else
    Console.WriteLine($"Точка пересечения: ({x:N3} , {y:N3} )");