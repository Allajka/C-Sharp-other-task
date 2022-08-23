//51. Задать двумерный массив следующим правилом: Aₘₙ = m+n

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

int[,] CreateArray(int row, int col)
{
    int[,] number = new int[row, col];
    for (int i = 0; i < number.GetLength(0); i++)
    {
        for (int j = 0; j < number.GetLength(1); j++)
        {
            number[i, j] = i + j;
        }
    }
    return number;
}

int [,] numbers = CreateArray(4, 4);
PrintArray(numbers);
System.Console.WriteLine();
PrintArray(numbers);
