// Задача 14: Найти третью цифру числа или сообщить, что её нет.
// Попытаюсь решить через массив, мне кажется такой вариант оптимальнее и универсальнее.

// Console.Write ("Введите число: ");

// string number = Console.ReadLine();

// char[] b = number.ToCharArray();

// char numbers = b[2];
//     if (sizeof= '\0');
//     Console.WriteLine("Нет третьей цифры");

// double getnum = Char.GetNumericValue(numbers);
// int toint = Convert.ToInt32(getnum);
    
// Console.WriteLine($"Третья цифра: {toint}");
 
Console.Write ("Введите число:");

string pars = Console.ReadLine();

pars = pars.Substring(2,1);
//  if (pars == null)

//  Console.WriteLine("нет третьего числа");

int number = int.Parse(pars);

 Console.WriteLine($"Третья цифра числа: {number}");

//Console.WriteLine(pars);

