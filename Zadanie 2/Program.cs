// Найти максимальное из трех чисел

Console.WriteLine ("Введите первое число");

string num1 = Console.ReadLine();

int n1 = int.Parse(num1);

Console.WriteLine ("Введите второе число");

string num2 = Console.ReadLine();

int n2 = int.Parse(num2);

Console.WriteLine ("Введите третье число");

string num3 = Console.ReadLine();

int n3 = int.Parse(num3);

int max = n1;

if (max < n2)
    max = n2;
if (max < n3)
    max = n3;    

Console.WriteLine($"Максимальное число {max}");
