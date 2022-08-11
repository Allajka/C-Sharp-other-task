// 13. Выяснить, кратно ли число заданному, если нет, вывести остаток.

double userNumberA = 1;
double userNumberB = 0;
double result = userNumberA % userNumberB;

if (userNumberA == 0 || userNumberB == 0) 
{
    Console.Write("Число 0 кратно любому числу в 0 раз."); 
}
else 
{
if (result == 0 || result == userNumberA)
{
    Console.Write($"Число {userNumberA} кратно {userNumberB}.");
}
else
{
    Console.Write($"Число {userNumberA} не кратно {userNumberB}. Остаток от деления {result}.");
}
}