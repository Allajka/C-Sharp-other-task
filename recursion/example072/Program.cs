// 72. Написать программу возведения числа А в целую степень B

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

int Degree(int number, int degree)
{
    if (degree == 1) return number;
    else return number * Degree(number, degree - 1);
}

Console.WriteLine("Программа возведения числа А в целую степень B.");
int A = CheckInput(text: "Введите число А для возведения его в степень: ");
int B = CheckInput(text: "Введите положительную целую степень В: ");

while (B <= 0)
{
    Console.ForegroundColor = ConsoleColor.Red;
    Console.WriteLine($"Для возведения числа {A} в степень, нужно ввести положительную целую степень. Повторите попытку ввода.");
    Console.ResetColor();
    B = CheckInput(text: "Введите положительную целю степень В: ");
}
Console.ForegroundColor = ConsoleColor.Green;
Console.WriteLine($"Ответ: {A} в степени {B} равно {Degree(A, B)}.");
Console.ResetColor();