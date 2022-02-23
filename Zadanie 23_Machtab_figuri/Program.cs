// Задача 42: Задача 46: Написать программу масштабирования фигуры
//Тут для тех кто далеко улетел, чтобы задавались вершины фигуры списком (одной строкой)
// например: "(0,0) (2,0) (2,2) (0,2)"
// коэффициент масштабирования k задавался отдельно - 2 или 4 или 0.5
// В результате показать координаты, которые получатся.
// при k = 2 получаем "(0,0) (4,0) (4,4) (0,4)"

// Пользователь вводит вершины фигуры в формате (х,у) (х1,у1) <..>
// парсим строку, вычленяем x, y , умножаем
bool StrArrayCheck(string[] array)
{
    
    bool result = true;
    int i = 0;
    while (result == true)
    {
        for (i = 0; i < array.Length; i++)
        {
            if (result == true)
            {
                result = double.TryParse(array[i], out double ChekOut);
            }
            else
            Console.WriteLine("В координатах содержатся недопустимые символы");
        }
    }
    
    return result;

}

Console.WriteLine("Введите вершины фигуры в формате (x,y) (x1,y1) <..>");
string StrValue = Console.ReadLine();
//Console.WriteLine(StrValue);
if (StrValue.StartsWith("(") && StrValue.EndsWith(")"))
{
    StrValue = StrValue.Replace("(", "").Replace(")", "").Replace(",", " ");
    string[] strArray = StrValue.Split(" ");
    // int j = 0;
    // while (j<strArray.Length)
    // {
    //     Console.Write(strArray[j]);
    //     j++;
    //     Console.WriteLine(strArray.Length);
    // }
    if (strArray.Length % 2 != 0 && StrArrayCheck(strArray) == false)
    {
        Console.WriteLine("Координаты заданы некорректно, требуемый формат ввода (х,у) (х1,у1) <...>");
    }
    else
    {
        Console.Write("Введие коэффициент масштабирования: ");
        string strMasht = Console.ReadLine();
        int i = 0;
        double k = double.Parse(strMasht);
        Console.WriteLine("Новые координаты: ");
        while (i < strArray.Length)
        {
            double x = k * (int.Parse(strArray[i]));
            double y = k * (int.Parse(strArray[i + 1]));
            Console.Write($"({x}, {y}) ");
            i = i + 2;
        }
    }
}
else
{
    Console.WriteLine("Координаты заданы не корректно, расчет не возможен.");
}



// for (int i = 0; i< strArray.Length; i = i++)
// {
//     Console.WriteLine(strArray[i]);
// }
