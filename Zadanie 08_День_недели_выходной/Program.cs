// Дано число обозначающее день недели. Выяснить является номер дня недели выходным.
int numberR = new Random().Next(1,8);
Console.WriteLine("Сгенерирован номер дня недели: "+ numberR);

int budni = 5;

if (numberR <= budni)
    Console.WriteLine("День недели не выходной, на работу товарищи!");
else
    Console.WriteLine("День недели выходной, отдыхаем!");
