// Задача 42: Определить сколько чисел больше 0 введено с клавиатуры



void GetPositiveNumsFromKeyboard(string msg) // 
{
    double positiveCount = 0;
    double negativeCount = 0;
    bool result = false;
    string message = null;
    while (result == false || message is null)
    {
        Console.Write(msg);
        string messageIn = Console.ReadLine();
        if (result = double.TryParse(messageIn, out double result_check) && result_check !> 0)
        {
            positiveCount++;
            result = false;
        }
        else if (result = double.TryParse(messageIn, out double result_checkNeg) && result_checkNeg !< 0)
        {
            negativeCount++;
            result = false;

        }
        else if (messageIn == "")
        {
            result = true;
            Console.WriteLine($"Введено чисел > 0 : {positiveCount} \nВведено чисел < 0 : {negativeCount}");
            break;
        }
    }
}

GetPositiveNumsFromKeyboard("Начните ввод чисел, чтобы остановить подсчет нажмите Enter : ");
