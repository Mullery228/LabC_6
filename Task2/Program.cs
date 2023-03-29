void Programm(double k1, double k2, double b1, double b2)
{
    double x = -(b1 - b2) / (k1 - k2);
    double y = k1 * x + b1;
    Console.WriteLine($"Точка пересечения: ({x};{y})");
}

Console.WriteLine("Введите параметр k1: ");
double k1 = Convert.ToDouble(Console.ReadLine());
Console.WriteLine("Введите параметр k2: ");
double k2 = Convert.ToDouble(Console.ReadLine());
Console.WriteLine("Введите параметр b1: ");
double b1 = Convert.ToDouble(Console.ReadLine());
Console.WriteLine("Введите параметр b2: ");
double b2 = Convert.ToDouble(Console.ReadLine());
Programm(k1, k2, b1, b2);