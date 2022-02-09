// Задача 14: Найти третью цифру числа или сообщить, что её нет.
// Попытаюсь решить через массив, мне кажется такой вариант оптимальнее и универсальнее.

// Console.Write ("Введите число: ");

// string number = Console.ReadLine();

// char[] b = number.ToCharArray();

// char numbers = b[2];

// double getnum = Char.GetNumericValue(numbers);
// int toint = Convert.ToInt32(getnum);
// int dec = -1;
//  if (toint == dec)
//     Console.WriteLine("введите число а не текст");
// else 
// Console.WriteLine($"Третья цифра: {toint}");

 
// // Console.Write ("Введите число:");

// // string pars = Console.ReadLine();

// // pars = pars.Substring(2,1);
// // //  if (pars == null)

// // //  Console.WriteLine("нет третьего числа");

// // int number = int.Parse(pars);

// //  Console.WriteLine($"Третья цифра числа: {number}");

//Console.WriteLine(pars)

Console.Write("Введите число: ");

string stringNumb = Console.ReadLine();

int.TryParse(stringNumb, out int sint);

string resint = sint.ToString();

int final = int.Parse(resint);
if (final > 0)
    Console.WriteLine($"Преобразуем число...");
else
Console.WriteLine("Вы ввели не числовое значение");

int GetCounts(int final)
{   
    int d = 99;
    int c = 0;
    while (final > d)
    {
        final = final/10;
        c++;
    }
    return c-1;

}

int GetThirdNumber(int final, int count)
{
    int track = 0;
     while (track < count)
        {
            final = final / 10;
            track++;
        }
        return final%10;
}



int counts = GetCounts(final);
int third = GetThirdNumber(final,counts);

if (final<=99)
    Console.WriteLine("В числе меньше трех цифр");
else
    Console.WriteLine($"Третья цифра числа: {third}");

    
