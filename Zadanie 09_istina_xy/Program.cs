// Задача 18: Проверить истинность утверждения ¬(X ⋁ Y) = ¬X ⋀ ¬Y
// Эту задачу я делал последней))) не придумал что вводить юзеру так, чтобы излишне не раздувать код, хотя наработки были, в итоге решил и так вся наглядно для юзера)))
// p.s по закону преобразований Де Моргана она решается в 1 шаг и левая часть равенства становится равна правой, тут и доказывать не чего :D 

Console.WriteLine("Проверить истинность утверждения : ¬(X v Y) = ¬X ^ ¬Y");
Console.WriteLine("Утверждение тождественно истинно, вариант расчёта для возможных пар X и Y: ");
int b = 1;
int i = 0;
bool x = true;
bool y = false;
if (b == 1)
    while (i == 0)
    {
        x = true;
        y = false;
        bool left = !(x || y);
        bool right = (!x) & (!y);
        bool itog = left == right;
        Console.WriteLine($" Х\tУ\t¬(X V Y)\t(¬X ^ ¬Y)\t¬(X V Y) = ¬X ^ ¬Y\n {x}\t{y}\t{left} \t \t{right}\t        {itog}");
        i++;
    }
    while (i != 2)
    {
         x = false;
         y = true;
        bool left = !(x || y);
        bool right = (!x) & (!y);
        bool itog = left == right;
        Console.WriteLine($" {x}\t{y}\t{left} \t \t{right}\t        {itog}");
        i++;
    }
        while (i != 3)
    {
        x = false;
        y = false;
        bool left = !(x || y);
        bool right = (!x) & (!y);
        bool itog = left == right;
        Console.WriteLine($" {x}\t{y}\t{left} \t \t{right}\t        {itog}");
        i++;
    }
     while (i != 4)
    {
        x = true;
        y = true;
        bool left = !(x || y);
        bool right = (!x) & (!y);
        bool itog = left == right;
        Console.WriteLine($" {x}\t{y}\t{left} \t \t{right}\t        {itog}");
        i++;

    }
