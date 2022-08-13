// 21. Программа проверяет пятизначное число на палиндромом.

Console.Write("Введите пятизначное число:  ");
int userDay = Convert.ToInt32(Console.ReadLine());
string lineNumber = Convert.ToString(userDay);

while (lineNumber.Length < 5)
{
    Console.Write("Введите число пятизначное число:  ");
    userDay = Convert.ToInt32(Console.ReadLine());
    lineNumber = Convert.ToString(userDay);
}

if (lineNumber[0] == lineNumber[4] && lineNumber[1] == lineNumber[3])
{
    Console.Write($"Число {lineNumber} палиндром.");
}
else
{
    Console.Write($"Число {lineNumber} Не палиндром.");
}