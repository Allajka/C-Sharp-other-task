/*  5. Написать программу вычисления значения функции y = f(a)*/
int CheckInput(string text, int number = -1)
{
    while (true)
    {
        Console.Write($"{text} ");
        string input = Console.ReadLine()!;
        bool flag = int.TryParse(input, out number);
        if (flag) break;
    }
    return number;
}

Console.WriteLine();
Console.WriteLine("Программа нахождения значений линейной функции вида: y = kx + b, где: \nk и b - числа, \nx - независимая переменная");
Console.WriteLine();

double k = CheckInput("Введите число k: ");
double b = CheckInput("Введите число b: ");;

double x0 = 0;
double x1 = 2;
double x2 = 4;
Console.WriteLine($"Графиком функции: y = {k}x + {b}  является прямая. \nДля построения графика, нам нужны координаты двух точек. Зададим значение x произвольным числом.");
double y0 = k*x0 + b;
double y1 = k*x1 + b;
double y2 = k*x2 + b;
Console.WriteLine($"При x = {x0}, получим у = {y0}\nПри x = {x1}, получим у = {y1}\nПри x = {x2}, получим у = {y2}\n ");
Console.WriteLine($"На координатной плоскости указываем три точки A({x0};{y0}), B({x1};{y1}), C({x2};{y2}) и соединяем их в прямую линию. ");