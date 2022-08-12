// 24. Найти кубы чисел от 1 до N

Console.Write("Введите число: ");
int N = Convert.ToInt32(Console.ReadLine());;
int index = 1;
int cube = 0;

while (index <= N)
{
    cube = index * index* index;
    Console.Write(" " + cube);
    index++;
    if (index % 10 == 0 )
    {
        Console.WriteLine();
    }
}