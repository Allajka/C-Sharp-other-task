// 54. В матрице чисел найти сумму элементов главной диагонали

int[,] CreateArray(int row, int col)
{
    int[,] arr = new int[row, col];
    for (int i = 0; i < arr.GetLength(0); i++)
    {
        for (int j = 0; j < arr.GetLength(1); j++)
        {
            arr[i, j] = new Random().Next(0, 10);
        }
    }
    return arr;
}

void PrintArray(int[,] arr)
{
    for (int i = 0; i < arr.GetLength(0); i++)
    {
        for (int j = 0; j < arr.GetLength(1); j++)
        {
            System.Console.Write($"{arr[i, j]} ");
        }
        System.Console.WriteLine();
    }
}
int SumHeadDiagonal(int[,] arr)
{
    int result = 0;
    if (arr.GetLength(1) % 2 == 0 && arr.GetLength(0) % 2 == 0)
    {
        for (int i = 0; i < 1; i++)
        {
            for (int j = 0; j < arr.GetLength(1); j++)
            {
                result += arr[j, j] + arr[j, arr.GetLength(1) - 1 - j];
            }
        }
    }
    else
    {
        for (int i = 0; i < 1; i++)
        {
            for (int j = 0; j < arr.GetLength(1); j++)
            {
                result += arr[j, j] + arr[j, arr.GetLength(1) - 1 - j];
            }
        }
    }
    return result;
}

int[,] numbers = CreateArray(5, 5);
if (numbers.GetLength(0) == numbers.GetLength(1))
{
    PrintArray(numbers);
    System.Console.WriteLine($"Сумма элементов главной диагонали = {SumHeadDiagonal(numbers)}.");
}
else System.Console.WriteLine($"Сумма элементов главной диагонали можно найти только в квадратной матрице");
