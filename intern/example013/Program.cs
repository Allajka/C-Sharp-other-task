// 13. Выяснить, кратно ли число заданному, если нет, вывести остаток.

double userNumberA = 28;
double userNumberB = 3;
double result = userNumberA % userNumberB;

if (result == userNumberA)
{
    Console.Write($"Число {userNumberA} кратно {userNumberB}.");
}
else
{
    Console.Write($"Число {userNumberA} не кратно {userNumberB}. Остаток от деления {result}.");
}