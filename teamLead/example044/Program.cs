/* 44. Найти точку пересечения двух прямых заданных уравнением:
y = k1 * x + b1, 
y = k2 * x + b2, 

b1 k1 и b2 и k2 заданы */

double k1 = 5;
double b1 = 2;
double k2 = 9;
double b2 = 4;

if (k1 == k2 || k1 == 0 || k2 == 0)
{
    Console.WriteLine("Нет точек пересечения");
}
else
{
    double x = - (b1 - b2)/(k1 - k2);
    double y = k2 * x + b2;
    System.Console.WriteLine($"Точка пересечения двух ({Math.Round(x, 2)}; {Math.Round(y, 2)}).");
}