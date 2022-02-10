// Задача 14: Найти третью цифру числа или сообщить, что её нет.

// Реализованы следующие проверки: 1. Ввод букв вместо число (сообщит и сбросит). 2. Ввод двузначного числа (сообщит и сбросит) 3. Ввод отрицательного числа (выдаст 3ю цифру.)

Console.Write("Введите число: ");

string stringNumb = Console.ReadLine();

int.TryParse(stringNumb, out int sint); // 

string resint = sint.ToString();  // отбрасываем 0 если пользователь ввел 000123

int final = int.Parse(resint); // возвращаем в int 
int digit = Math.Abs(final); // преобразуем отрицательное число если пользователь ввел -123
if (digit > 0)
    Console.WriteLine($"Преобразуем число...");
else
Console.WriteLine("Вы ввели не числовое значение");

int GetCounts(int digit) /// считаем разряды числа 
{   
    int d = 99;
    int c = 0;
    while (digit > d)
    {
        digit = digit/10;
        c++;
    }
    return c-1;

}

int GetThirdNumber(int digit, int count) // Получаем третью цифру числа, сокращаем его до 3 потом остаток от деления
{
    int track = 0;
     while (track < count)
        {
            digit = digit / 10;
            track++;
        }
        return digit%10;
}



int counts = GetCounts(digit); /// получаем разряды 
int third = GetThirdNumber(digit,counts); // сокращаем и получаем 3 цифру числа

if (digit<=99)
    Console.WriteLine("В числе меньше трех цифр");
else
    Console.WriteLine($"Третья цифра числа: {third}");

    
