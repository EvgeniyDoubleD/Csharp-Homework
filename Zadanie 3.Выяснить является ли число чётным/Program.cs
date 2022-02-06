//Выяснить является ли число чётным

Console.WriteLine ("Введите число");

string num1 = Console.ReadLine();

int n1 = int.Parse(num1);

int chetnoe = n1 % 2;

if (chetnoe == 0)
    Console.WriteLine($"Число {n1} является четным");
    else
    Console.WriteLine($"Число {n1} является не четным");
