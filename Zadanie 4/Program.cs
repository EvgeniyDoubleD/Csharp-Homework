// Показать четные числа от 1 до N
Console.Write ("Введите число больше 1: ");

string numbers = Console.ReadLine();

int number = int.Parse(numbers);

int numberCh = 2;

while (numberCh <= number)
{
    Console.Write($"{numberCh}" + " ");
   numberCh = numberCh+2;
}
