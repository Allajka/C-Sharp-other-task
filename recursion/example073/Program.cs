/* 73. Написать программу показывающие первые N чисел, для которых каждое следующее равно сумме двух предыдущих. 
Первые два элемента последовательности задаются пользователем */

void LineSumTwoNumber(int firstNumber, int secondNumber, int count, int sum = 0)
{
    sum = firstNumber + secondNumber;
    if (0 == count) Console.Write($"{sum} ");
    else
    {
        Console.Write($"{sum} ");
        LineSumTwoNumber(firstNumber: secondNumber, secondNumber: sum, count: count - 1);
    }
}

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

Console.WriteLine("Программа показывающая первые N чисел, для которых каждое следующее равно сумме двух предыдущих.");
int A = CheckInput("Введите первое число: ");
int B = CheckInput("Введите второе число: ");;
int sum = A + B;
int and = 20;

Console.Write($"{A} {B} "); 
LineSumTwoNumber(firstNumber: A, secondNumber: B, count: and);

