// 7. Показать числа от -N до N

// Console.Write("Введите число: ");
// int userNumber = Convert.ToInt32(Console.ReadLine());
// string result = "";
// int index = - userNumber;

// while (index <= 0)
// {
//     result = result + index + " ";
//     index++;
// }

// index = 0;

// while (index < userNumber)
// {
//     index++;
//     result = result + index + " ";
// }

// Console.Write(result);

// 7. Показать числа от -N до N
Console.Write("Введите число: ");
int N = Convert.ToInt32(Console.ReadLine());
int[] array = new int[N * 2 + 1];
int index = 0;

while (index <= N)
{
    array[index] = -N + index;
    index++;
}

while (index <= N*2)
{
    array[index] = index-N;
    index++;
}

index = 0;
while (index < (N * 2 + 1))
{
    Console.Write(array[index] + " ");
    index++;
}



