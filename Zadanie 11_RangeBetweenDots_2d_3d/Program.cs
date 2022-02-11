// Задача 22: Найти расстояние между точками в пространстве 2D/3D
// Пользователь вводит поочередно координаты х - у - z - для каждой точки. Тип пусть будет дабл.
// Координаты проверяются на ввод текста /repeat , 0123 - дабл решает проблему ,  отрицательные значения допустимы.
// Расчёт расстояния между точек: на выбор  0 - 2д 1 - 3д. Если пользователь задал (1.2.0)

double GetCoordinate(string msg) // метод ввода точки координат с проверкой на текст введенный.
{
    double result = 0;
    while (result == 0)
    {
        Console.WriteLine(msg);
        string message = Console.ReadLine();
        double.TryParse(message, out double result_check);
        result = result_check;
    }
    return result;
}   

