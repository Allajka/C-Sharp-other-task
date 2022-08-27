// 59. В прямоугольной матрице найти строку с наименьшей суммой элементов.

int[,] CreateArray(int row, int col)
{
    int[,] numbers = new int[row, col];
    for (int i = 0; i < numbers.GetLength(0); i++)
    {
        for (int j = 0; j < numbers.GetLength(0); j++)
        {
            numbers[i, j] = new Random().Next(0, 10);
        }
    }
    return numbers;
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
int[,] numbers = CreateArray(row: 5, col: 8);
PrintArray(numbers);

int SumRow(int[,] arr, int row)
{
    int sum = 0;
    for (int i = 0; i < arr.GetLength(1); i++)
    {
        sum += arr[row, i];
    }
    return sum;
}

for (int i = 0; i < 1; i++)
{
    int minSumRow = SumRow(numbers, row: i);
    for (int j = 1; j < numbers.GetLength(0); j++)
    {
        int sumRow = SumRow(numbers, row: j);
        if (sumRow < Convert.ToInt32(minSumRow)) minSumRow = sumRow;
    }
    Console.WriteLine($"minSumRow: {minSumRow}");
}