// Найти точку пересечения двух прямых заданных уравнением y = k1 * x + b1, y = k2 * x + b2    b1 k1 и b2 и k2 заданы
// сперва надо решить систему уравнений  y-y = k1*x+b1-k2*x+b2; 0 = k1*x-b1 y = k2*x + b2; 
// x = b1/k1 y = k2*x+b2

double b1 = 2;
double k1 = 5;
double b2 = 1;
double k2 = -3;

double x = b1/k1;
double y = k2*x+b2;

Console.WriteLine($"Точка пересечения: ({x:N3} , {y:N3} )");