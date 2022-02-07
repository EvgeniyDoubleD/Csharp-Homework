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

int InPut(string msg)
{
    Console.Write(msg);
    string num = Console.ReadLine();
    return int.Parse(num);
}

int GetCounts(int number)
{   
    int d = 99;
    int c = 0;
    while (number > d)
    {
        number = number/10;
        c++;
    }
    return c-1;

}

int GetThirdNumber(int number, int count)
{
    int track = 0;
     while (track < count)
        {
            number = number / 10;
            track++;
        }
        return number%10;
}


int number = InPut("Введите натуральное целое число: ");
int counts = GetCounts(number);
int third = GetThirdNumber(number,counts);

if (number<=99)
    Console.WriteLine("В числе меньше трех цифр");
else
    Console.WriteLine($"Третья цифра числа: {third}");

    
