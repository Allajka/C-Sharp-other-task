// 13. Выяснить, кратно ли число заданному, если нет, вывести остаток.

double userNumberA = 2;
double userNumberB = 7;
double result = userNumberA / userNumberB;
double result2 = userNumberA % userNumberB;
Console.WriteLine(result + " " + result2);

double x = 10;
double y = 3;
double z;
z = x / y - y;
Console.WriteLine(z);

// if (result == userNumberA)
// {
//     Console.Write($"Число {userNumberA} кратно {userNumberB}");
// }
// else
// {
//     Console.Write($"Остаток от деления {userNumberA} и {userNumberB} = {result}");
// }