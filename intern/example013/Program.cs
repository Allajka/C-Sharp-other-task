// 13. Выяснить, кратно ли число заданному, если нет, вывести остаток.

Console.Write("Введите первое число: "); 
double userNumberA = Convert.ToDouble(Console.ReadLine());
Console.Write("Введите первое число: "); 
double userNumberB = Convert.ToDouble(Console.ReadLine());
double result = userNumberB % userNumberA;

if (userNumberA == 0 || userNumberB == 0) 
{
    Console.Write("Число 0 кратно любому числу в 0 раз."); 
}
else 
{
    if (result == 0 )
    {
        Console.Write($"Число {userNumberA} кратно {userNumberB}.");
    }
    else
    {
        Console.Write($"Число {userNumberA} не кратно {userNumberB}. Остаток от деления {result}.");
}
}
