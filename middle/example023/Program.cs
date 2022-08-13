// 23. Показать таблицу квадратов чисел от 1 до N 

Console.Write("Введите число: ");
int N = Convert.ToInt32(Console.ReadLine());;
int index = 1;
int square = 0;

while (index <= N)
{
    square = index * index;
    Console.Write($"{square,-6}"); // 6 кол-во отступов можно (- минус) прижимаем к другому краю
    index++;
    if (index % 10 == 0 )
    {
        Console.WriteLine();
    }
}