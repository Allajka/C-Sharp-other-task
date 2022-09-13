// 43. Написать программу преобразования десятичного числа в двоичное

long binaryTransfer(long number)
{
    long binaryNumber = number % 2;
    long ten = 10;

    while (number > 0)
    {
        System.Console.WriteLine($"binaryNumber {binaryNumber} += ((number{number} / 2) % 2) * ten{ten};");
        binaryNumber += ((number / 2) % 2) * ten;
        number /= 2;
        ten *= 10;
    }
    return binaryNumber;
}

Console.Write("Введите десятичное число для перевода его в двоичную систему счисления: ");
long number = Convert.ToInt32(Console.ReadLine());
long binaryNumber = binaryTransfer(number);
System.Console.WriteLine($"Число {number} в двоичной системе счисления: {binaryNumber}");