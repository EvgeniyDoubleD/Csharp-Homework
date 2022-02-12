// Задача 22: Найти расстояние между точками в пространстве 2D/3D
// Пользователь вводит поочередно координаты х - у - z - для двух точек А и В (опционально можно расширить пулл точек) Тип пусть будет дабл.
// Координаты проверяются на ввод текста /repeat , 0123 - дабл решает проблему ,  отрицательные значения допустимы.
// Расчёт расстояния между точек: на выбор  3д - Если пользователь задал (1.2.1), 2д - Если пользоватеь задал 2 из 3 цифр.

double GetCoordinate(string msg) // метод ввода точки координат с проверкой "на дурака"
{
    double coordinate = 0;
    bool result = false;
    string message = null;
    while (result == false || message is null)
    {
        Console.Write(msg);
        string messageIn = Console.ReadLine();
        if (result = double.TryParse(messageIn, out double result_check));
           {
            coordinate = result_check;
            message = messageIn;
           }
    }
    return coordinate;
}   

void DoNiceFormatOutput() // метод "красивого" разделения вывода данных в консоли :>
{
    Console.WriteLine("======================================");
}

DoNiceFormatOutput();

double x_one = GetCoordinate("Точка A.\nВведите координаты по оси Х: ");
double y_one = GetCoordinate("Введите координаты по оси Y: ");
double z_one = GetCoordinate("Введите координаты по оси Z: ");
double x_two = GetCoordinate("Точка B.\nВведите координаты по оси Х: ");
double y_two = GetCoordinate("Введите координаты по оси Y: ");
double z_two = GetCoordinate("Введите координаты по оси Z: ");

DoNiceFormatOutput();

Console.WriteLine($"Координаты точки А: ({x_one} , {y_one} , {z_one})\nКоординаты точки B: ({x_two} , {y_two} , {z_two})");

DoNiceFormatOutput();

double distance = Math.Sqrt((Math.Pow((x_two - x_one),2) + Math.Pow((y_two - y_one),2) + Math.Pow((z_two - z_one),2))); // формула расчета расстояния 2д/3д смотря как заданы координаты.

Console.WriteLine($"Расстояние между указанными точками составляет : {distance}");

DoNiceFormatOutput();
