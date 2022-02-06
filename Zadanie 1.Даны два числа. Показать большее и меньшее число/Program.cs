// Даны два числа. Показать большее и меньшее число
Console.WriteLine ("Введите первое число");

string num1 = Console.ReadLine();

int n1 = int.Parse(num1);

Console.WriteLine ("Введите второе число");

string num2 = Console.ReadLine();

int n2 = int.Parse(num2);

if (n1>n2)
    Console.WriteLine("Первое число больше второго");
    else
    Console.WriteLine("Второе число больше первого");

Console.WriteLine("Вы молодец");