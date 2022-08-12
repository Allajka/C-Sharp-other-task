// 25. Найти сумму чисел от 1 до А

Console.Write("Введите число: ");
int A = Convert.ToInt32(Console.ReadLine());
int result = 0;

for (int i = 1; i<=A; i++)
{
    result += i;
}

Console.Write($"Сумма чисел от 1 до {A} равна {result}");