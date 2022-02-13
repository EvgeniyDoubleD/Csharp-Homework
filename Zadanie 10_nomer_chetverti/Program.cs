// Задача 20: Задать номер четверти, показать диапазоны для возможных координат
// 1. Создать массив с диапозонами возможных координат прим. [] m ={ x - 1 -> + + ∞ | y = 1 -> 8,   x→ (+) x→∞x3(1−4x2+1x3)x3(1+1x−2x3)∞
// 2. делаем за один метод войд - человек вводит цифру метод проверяет всё ли окей в части данных потом из массива берет индекс и выводит диапозон возможных координат.

int GetNumberOfQuarter(string msg) // метод выбора четверти с проверкой "на дурака" и информацией о выборе.
{
    int choise = 0;
    bool result = false;
    while (result == false && choise == 0)
    {
        Console.Write(msg);
        string message = Console.ReadLine();
        if (result = int.TryParse(message, out int result_check) && result_check >= 1 && result_check <= 4)
        {
            if (result_check == 1)
                    {
                        choise = result_check;
                        Console.WriteLine("Выбрана 1-я четверть.");
                    }
                if (result_check == 2)
                    {
                        choise = result_check;
                        Console.WriteLine("Выбрана 2-я четверть.");
                    }
                        if (result_check == 3)
                        {
                            choise = result_check;
                            Console.WriteLine("Выбрана 3-я четверть.");
                        }
                            if (result_check == 4)
                            {
                                choise = result_check;
                                Console.WriteLine("Выбрана 4-я четверть.");
                            }

        }

    }
    return choise;
}

string [] diapazon = { "(x → +oo , y → +oo)" , "(x → -oo , y → +oo)", "(x → -oo , y → -oo)", "(x → +oo , y → -oo)" }; // символ ∞ не выводит в консоль :(

int diap = GetNumberOfQuarter("Укажите номер четверти с 1 по 4: ");

Console.Write($"Диапазон возможных координат данной четверти - {diapazon [diap-1]}"); 
