// Задача 22: Найти расстояние между точками в пространстве 2D/3D
// Пользователь вводит поочередно координаты х - у - z - для двух точек А и В (опционально можно расширить пулл точек) Тип размуеется дабл.))
// Координаты проверяются на ввод текста /repeat/ , 0123 - дабл решает проблему ,  отрицательные значения допустимы.
// Расчёт расстояния между точек: на выбор  3д - Если пользователь указал 2 , 2д - указал 1 в терминале.
// double distance = Math.Sqrt((Math.Pow((x_two - x_one),2) + Math.Pow((y_two - y_one),2) + Math.Pow((z_two - z_one),2))); // формула расчета расстояния 2д/3д смотря как заданы координаты.

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

double GiveAchoise(string msg) // метод выбора типа пространства 2д / 3д 
{
    double choise = 0;
    bool result = false;
    while (result == false && choise == 0)
    {
        Console.Write(msg);
        string messageIn = Console.ReadLine();
        if (result = double.TryParse(messageIn, out double result_check) &&  result_check == 1 || result_check == 2)
        {
            if (result_check == 1)
                {
                    choise = result_check;
                    Console.WriteLine("Выбрано 2D пространство");
                }
            else if (result_check == 2)
                {
                    choise = result_check;
                    Console.WriteLine("Выбрано 3D пространство");
                }

        }
    }
    return choise;
}   

void DoNiceFormatOutput() // метод "красивого" разделения вывода данных в консоли :>
{
    Console.WriteLine("======================================");
}

DoNiceFormatOutput();

double choise = GiveAchoise("Введите цифру чтобы указать тип пространства в котором необходимо осуществить поиск расстояния: 1 - 2D, 2 - 3D : ");

DoNiceFormatOutput();

if (choise == 1)
    {
        double x_one = GetCoordinate("Точка A\nВведите координаты по оси Х: ");
        double y_one = GetCoordinate("Введите координаты по оси Y: ");
        double z_one = 0;
        double x_two = GetCoordinate("Точка B\nВведите координаты по оси Х: ");
        double y_two = GetCoordinate("Введите координаты по оси Y: ");
        double z_two = 0;
    
        DoNiceFormatOutput();
        
        Console.WriteLine($"Координаты точки А: ({x_one} , {y_one} )\nКоординаты точки B: ({x_two} , {y_two} )");
        
        DoNiceFormatOutput();

        double distance = Math.Sqrt((Math.Pow((x_two - x_one),2) + Math.Pow((y_two - y_one),2) + Math.Pow((z_two - z_one),2)));

        Console.WriteLine($"Расстояние между указанными точками составляет : {distance}");

        DoNiceFormatOutput();
    }
if (choise == 2)
    {
        double x_one = GetCoordinate("Точка A\nВведите координаты по оси Х: ");
        double y_one = GetCoordinate("Введите координаты по оси Y: ");
        double z_one = GetCoordinate("Введите координаты по оси Z: ");
        double x_two = GetCoordinate("Точка B\nВведите координаты по оси Х: ");
        double y_two = GetCoordinate("Введите координаты по оси Y: ");
        double z_two = GetCoordinate("Введите координаты по оси Z: ");

        DoNiceFormatOutput();

        Console.WriteLine($"Координаты точки А: ({x_one} , {y_one} , {z_one})\nКоординаты точки B: ({x_two} , {y_two} , {z_two})");

        DoNiceFormatOutput();

        double distance = Math.Sqrt((Math.Pow((x_two - x_one),2) + Math.Pow((y_two - y_one),2) + Math.Pow((z_two - z_one),2)));

        Console.WriteLine($"Расстояние между указанными точками составляет : {distance}");

        DoNiceFormatOutput();
    }




