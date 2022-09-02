// Показать натуральные числа от 1 до N, N задано

int N = 50;

void PrintNumberLine(int lastNumber, int firstNumber = 1)
{
    if (lastNumber == firstNumber) Console.Write(lastNumber);
    else
    {
        Console.Write($"{firstNumber} ");
        PrintNumberLine(lastNumber, firstNumber + 1);
    }
}

PrintNumberLine(N);