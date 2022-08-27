// 58. Написать программу, которая в двумерном массиве заменяет строки на столбцы или сообщить, что это невозможно (в случае, если матрица не квадратная).

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
int[,] ChangeRowsToCol(int[,] arr)
{
    int[,] newArr = new int[arr.GetLength(0), arr.GetLength(1)];
    for (int i = 0; i < arr.GetLength(0); i++)
    {
        for (int j = 0; j < arr.GetLength(1); j++)
        {
            newArr[j, i] = arr[i, j];
        }
    }
    return newArr;
}

int[,] numbers = CreateArray(row: 5, col: 6);
PrintArray(numbers);

if (numbers.GetLength(0) == numbers.GetLength(1))
{
    numbers = ChangeRowsToCol(numbers);
    Console.WriteLine();
    PrintArray(numbers);
}
else
{
    System.Console.WriteLine("Матрица не квадратная, не возможно заменить строки на столбцы.");
}