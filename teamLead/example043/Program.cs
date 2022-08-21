// 43. Написать программу преобразования десятичного числа в двоичное

void binaryTransfer(int number)
{
    decimal binaryNumber = number % 2;
    int ten = 10;

    while (number > 0)
    {
        binaryNumber += ((number / 2) % 2) * ten;
        number /= 2;
        ten *= 10;
        System.Console.WriteLine($"binaryNumber {binaryNumber}, number {number}");
    }
    System.Console.WriteLine($"Число {number} в двоичной системе счисления: {binaryNumber}");
}

Console.Write("Введите десятичное число для перевода его в двоичную систему счисления: ");
int number = Convert.ToInt32(Console.ReadLine());
binaryTransfer(number);