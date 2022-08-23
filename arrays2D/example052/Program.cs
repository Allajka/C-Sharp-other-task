// 52. В двумерном массиве заменить элементы, у которых оба индекса чётные на их квадраты

void PrintArray(int[,] arr)
{
    for (int i = 0; i < arr.GetLength(0); i++)
    {
        for (int j = 0; j < arr.GetLength(1); j++)
        {
            System.Console.Write($"{arr[i, j],3} ");
        }
        System.Console.WriteLine();
    }
}

int[,] CreateArray(int row, int col)
{
    int[,] number = new int[row, col];
    for (int i = 0; i < number.GetLength(0); i++)
    {
        for (int j = 0; j < number.GetLength(1); j++)
        {
            number[i, j] = new Random().Next(0, 10);
        }
    }
    return number;
}

int[,] ChangeEvenPositions(int[,] arr)
{
    for (int i = 0; i < arr.GetLength(0); i++)
    {
        for (int j = 0; j < arr.GetLength(1); j++)
        {
            if (i % 2 == 0 && j % 2 == 0 && i != 0 && j != 0)
            {
                arr[i, j] = arr[i, j] * arr[i, j];
            }
        }
    }
    return arr;
}
int[,] numbers = CreateArray(5, 5);
PrintArray(numbers);
System.Console.WriteLine();
ChangeEvenPositions(numbers);
PrintArray(numbers);