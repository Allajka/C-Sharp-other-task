// 28. Подсчитать сумму цифр в числе

Console.Write("Введите число: ");
int number = Convert.ToInt32(Console.ReadLine());
int box = number;
int sum = 0;
while (box > 0)
{
    sum += box % 10;
    box /= 10;
}

Console.WriteLine($"Сумма цифр в числе {number} = {sum}");