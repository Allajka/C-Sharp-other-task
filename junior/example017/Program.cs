// 17. По двум заданным числам проверять является ли одно квадратом другого

Console.Write("Проверка является ли число A, квадратом B.\n");
Console.Write("Введите первое число: ");
int numberA = Convert.ToInt32(Console.ReadLine());
Console.Write("Введите второе число: ");
int numberB = Convert.ToInt32(Console.ReadLine());

if ((numberB*numberB) == numberA)
{
    Console.WriteLine ($"Да, {numberA} является квадратом {numberB}");
} 
else
{
    Console.WriteLine ($"Нет, {numberA} НЕ является квадратом {numberB}");
}