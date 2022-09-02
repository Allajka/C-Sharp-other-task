// 67. Показать натуральные числа от N до 1, N задано

int N = 50;

void PrintNumberLine(int firstNumber, int lastNumber = 1)
{
    if (lastNumber == firstNumber) Console.Write(lastNumber);
    else
    {
        Console.Write($"{firstNumber} ");
        PrintNumberLine(firstNumber - 1, lastNumber);
    }
}

PrintNumberLine(firstNumber: N);