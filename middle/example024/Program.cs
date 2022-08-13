// 24. Найти кубы чисел от 1 до N

Console.Write("Введите число: ");
double N = Convert.ToDouble(Console.ReadLine());;
double index = 1;
double cube = 0;

while (index <= N)
{
    cube = Math.Pow(index, 3);
    Console.Write($"{cube, 8}"); // 8 кол-во отступов можно (- минус) прижимаем к другому краю
    index++;
    if (index % 10 == 0 )
    {
        Console.WriteLine();
    }
}

// Console.Write("Введите число: ");
// int N = Convert.ToInt32(Console.ReadLine());;
// int index = 1;
// int cube = 0;

// while (index <= N)
// {
//     cube = index * index* index;
//     Console.Write(" " + cube);
//     index++;
//     if (index % 10 == 0 )
//     {
//         Console.WriteLine();
//     }
// }