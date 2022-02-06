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

string numberstring = Console.ReadLine();

int numberint = int.Parse(numberstring);

int i = 1;

int c = 0;

int j = numberint;

int f = numberint;


while (j%100 > i)
{
    {   
        j = j / 10;
        c++;
        Console.WriteLine($"While j = {j}");
        Console.WriteLine($"Iterations =  {c}");
    

    }

}

int b = 0;

while (b < c-2)
{
    {
     f = f / 10;

     Console.WriteLine($"Number = {f}");

     b++;

     Console.WriteLine($"Delenie raz ={b}");



     }


}

int x = f % 10;

    Console.WriteLine($"Третья цифра числа - {x}");
    
