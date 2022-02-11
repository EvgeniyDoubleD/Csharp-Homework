// Задача 22: Найти расстояние между точками в пространстве 2D/3D
// Пользователь вводит поочередно координаты х - у - z - для каждой точки. Тип пусть будет дабл.
// Координаты проверяются на ввод текста /repeat , 0123 - дабл решает проблему ,  отрицательные значения допустимы.
// Расчёт расстояния между точек: на выбор  0 - 2д 1 - 3д. Если пользователь задал (1.2.0)

double GetCoordinate(string msg) // метод ввода точки координат с проверкой на текст введенный.
{
    double result = 0;
    string message = null;
    while (result == 0 || message is null)
    {
        Console.Write(msg);
        string messageIn = Console.ReadLine();
        double.TryParse(message, out double result_check);
        result = result_check;
        message = messageIn;
    }
    return result;
}   

double x_one = GetCoordinate("Параметр точки №1. Введите координаты по оси Х: ");
double y_one = GetCoordinate("Параметр точки №1. Введите координаты по оси Y: ");
double z_one = GetCoordinate("Параметр точки №1. Введите координаты по оси Z: ");
double x_two = GetCoordinate("Параметр точки №2. Введите координаты по оси Х: ");
double y_two = GetCoordinate("Параметр точки №2. Введите координаты по оси Y: ");
double z_two = GetCoordinate("Параметр точки №2. Введите координаты по оси Z: ");

Console.WriteLine($"Координаты точки №1: {x_one} {y_one} {z_one}\nКоординаты точки №2: {x_two} {y_two} {z_two}");

double distance = Math.Sqrt((Math.Pow((x_two - x_one),2) + Math.Pow((y_two - y_one),2) + Math.Pow((z_two - z_one),2))); // формула расчета расстояния 3д работает 2д под вопросом.

Console.WriteLine($"Расстояние между указаными точками : {distance}");

double checkout = Math.Sqrt((Math.Pow((x_two - (x_one)),2)));

double check = Math.Sqrt((Math.Pow((y_two - y_one),2)));

Console.WriteLine($"checkout = {checkout}; check = {check}");