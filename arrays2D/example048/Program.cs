// 48. Показать двумерный массив размером m×n заполненный целыми числами

void PrintArray (int[,] arr)
{
    for (int i = 0; i < arr.GetLength(0); i++)
    {
        for (int j = 0; j < arr.GetLength(1); j++)
        {
            Console.Write($"{arr[i,j], 3}");
        }
        Console.WriteLine();
    }
}

int [,] CreateArray (int row, int col)
{
    int[,] numbers = new int [row,col];
    for (int i = 0; i < numbers.GetLength(0); i++)
    {
        for (int j = 0; j < numbers.GetLength(1); j++)
        {
            numbers [i,j] = new Random().Next(0, 100);
        }
    }
    return numbers;
}
int[,] numbers = CreateArray(row: 5, col: 4);
PrintArray(numbers);
