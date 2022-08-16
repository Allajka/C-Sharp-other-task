// 30. Показать кубы чисел, заканчивающихся на четную цифру

Console.Write("Введите число: ");
double N = Convert.ToDouble(Console.ReadLine());;
double index = 1;
double cube = 0;

while (index <= N)
{
    cube = Math.Pow(index, 3);
    if (cube % 2 == 0)
    {
        Console.Write($"{cube, 8}"); // 8 кол-во отступов можно (- минус) прижимаем к другому краю
    }

    if (index % 10 == 0 )
    {
        Console.WriteLine();
    }
    index++;
}
