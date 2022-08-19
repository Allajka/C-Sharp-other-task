// 43. Написать программу преобразования десятичного числа в двоичное

int binaryTransfer (int number)
{
    int binaryNumber = 0;
    int ten = 1;

    while (number > 0)
    {
        binaryNumber = binaryNumber + (number % 2) * ten;
        number /= 2;
        ten *= 10;
    }
    return binaryNumber;
}

Console.Write("Введите десятичное число для перевода его в двоичную систему счисления: ");
int number = Convert.ToInt32(Console.ReadLine());
int binaryNumber = binaryTransfer(number);

System.Console.WriteLine($"Число {number} в двоичной системе счисления: {binaryNumber}");
