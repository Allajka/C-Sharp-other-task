// 29. Написать программу вычисления произведения чисел от 1 до N

Console.Write("Вычисление произведения числа от 1 до N. Введите N: ");
double  userN = Convert.ToDouble(Console.ReadLine());;
double  result = 1;

for (double  i = 2; i <= userN; i++)
{
    result *= i;
}
Console.WriteLine(result);