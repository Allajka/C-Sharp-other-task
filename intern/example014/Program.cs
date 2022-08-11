// 14. Найти третью цифру числа или сообщить, что её нет

int checkNumber(int numbers)
{
    int amountNumber = 0;
    while (numbers > 0)
    {
        numbers /= 10;
        amountNumber++;
    }
    return amountNumber;
}

int number = new Random().Next(1, 10000);
int sumNumber = checkNumber(number);
int control = sumNumber - 3;
int i = 0;

if (sumNumber >= 3)
{
    while (i < control)
    {
        number = number / 10;
        i++;
    }
    int thirdNumber = number % 10;
    Console.WriteLine($"Третья цифра {number} числа {thirdNumber}");
}

if (sumNumber < 3)
{
    Console.WriteLine("Нет третьей цифры в числе {number} ");
}