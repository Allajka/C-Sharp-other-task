// 49. Показать двумерный массив размером m×n заполненный вещественными числами

void PrintArray (double[,] arr)
{
    for (int i = 0; i < arr.GetLength(0); i++)
    {
        for (int j = 0; j < arr.GetLength(1); j++)
        {
            Console.Write($"{arr[i,j], 8}");
        }
        Console.WriteLine();
    }
}

double [,] CreateArray (int row, int col)
{
    double[,] numbers = new double [row,col];
    for (int i = 0; i < numbers.GetLength(0); i++)
    {
        for (int j = 0; j < numbers.GetLength(1); j++)
        {
            numbers [i,j] = Math.Round(new Random().NextDouble() *100, 2);
        }
    }
    return numbers;
}
double[,] numbers = CreateArray(row: 5, col: 4);
PrintArray(numbers);