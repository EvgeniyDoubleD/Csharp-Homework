// Задача 42: Задача 46: Написать программу масштабирования фигуры
//Тут для тех кто далеко улетел, чтобы задавались вершины фигуры списком (одной строкой)
// например: "(0,0) (2,0) (2,2) (0,2)"
// коэффициент масштабирования k задавался отдельно - 2 или 4 или 0.5
// В результате показать координаты, которые получатся.
// при k = 2 получаем "(0,0) (4,0) (4,4) (0,4)"

// Пользователь вводит вершины фигуры в формате (х,у) (х1,у1) <..>
// парсим строку, вычленяем x, y , умножаем

Console.WriteLine("Введите вершины фигуры в формате (x,y) (x1,y1) <..>");
string strValue = Console.ReadLine();
if (strValue.StartsWith("(") && strValue.EndsWith(")"))
{
    strValue = strValue.Replace("(", "").Replace(")", "").Replace(",", " ");
    string[] strArr = strValue.Split(" ");
    if (strArr.Length % 2 != 0)
    {
        Console.WriteLine("Координаты заданы некорректно, требуемый формат ввода (х,у) (х1,у1) <...>");
    }
    else if (strArr.Length % 2 == 0)
    {
        Console.Write("Введие коэффициент масштабирования: ");
        string strMasht = Console.ReadLine();
        int i = 0;
        double k = double.Parse(strMasht);
        Console.WriteLine("Новые координаты: ");
        while (i < strArr.Length)
        {
            double x = k * (int.Parse(strArr[i]));
            double y = k * (int.Parse(strArr[i + 1]));
            Console.Write($"({x}, {y}) ");
            i = i + 2;
        }
    }
}
else
{
    Console.WriteLine("Координаты заданы не корректно, расчет не возможен.");
}
