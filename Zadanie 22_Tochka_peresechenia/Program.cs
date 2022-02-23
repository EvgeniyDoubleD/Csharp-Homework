// Найти точку пересечения двух прямых заданных уравнением y = k1 * x + b1, y = k2 * x + b2    b1 k1 и b2 и k2 заданы
// сперва надо решить систему уравнений  приравняем уравнения:
// K1x+b1=K2x+b2 -> K1x-K2x=b2-b1 -> x = (b2-b1)/(K1-K2)
// x = b1/k1 y = k2*x+b2

double b1 = -1;
double k1 = 2;
double b2 = 1;
double k2 = 2;

double x = (b2-b1)/(k1-k2);
double y = (k2*x)+b2;

if (k1 == k2)
    Console.WriteLine("Прямые не пересекаются");
else
Console.WriteLine($"Точка пересечения: ({x:N3} , {y:N3} )");