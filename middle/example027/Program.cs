// 27. Определить количество цифр в числе

Console.Write("Введите число: ");
int userNumber = Convert.ToInt32(Console.ReadLine()); 
int box = userNumber;
int amountNumber = 0;
while (box > 0)
{
    box /= 10;
    amountNumber++;
}

if (userNumber == 0) Console.WriteLine($"В числе {userNumber} - 1 цифр.");
else Console.WriteLine($"В числе {userNumber} - {amountNumber} цифр.");