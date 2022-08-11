// 1. По двум заданным числам проверять является ли первое квадратом второго

Console.WriteLine("Проверка является ли первое число квадратом второго.");
Console.Write("Введите первое число: ");
int userNumber = Convert.ToInt32(Console.ReadLine());
Console.Write("Введите второе число: ");
int userNumber2 = Convert.ToInt32(Console.ReadLine());

if ( userNumber2 == userNumber*userNumber)
{
    Console.Write($"{userNumber} является квадратом {userNumber2}");
}
else
{
    Console.Write($"{userNumber} НЕ является квадратом {userNumber2}");
}

