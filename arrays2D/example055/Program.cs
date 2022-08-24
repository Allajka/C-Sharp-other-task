// 55. Дан целочисленный массив. Найти среднее арифметическое каждого из столбцов.
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

double MiddleNumberCol(int[,] arr, int col)
{
    double result = 0;
    for (int i = 0; i < arr.GetLength(0); i++)
    {
        result += arr[i, col];
    }
    return result / arr.GetLength(1);
}

int[,] numbers = CreateArray(5, 5);
PrintArray(numbers);

for (int i = 0; i < numbers.GetLength(1); i++)
{
    double average = MiddleNumberCol(numbers, i);
    Console.WriteLine($"Cреднее арифметическое столбца {i + 1} = {average}.");
}