// Найти сумму цифр числа 

int number = 2563;

int SunNumbers(int number, int result = 0)
{
    if (number == 0) return result;
    else 
    {
        result += number%10;
        number = number/10;
        return SunNumbers(number, result);
    }
}

Console.WriteLine(SunNumbers(number)); 
