// 56. Написать программу, которая обменивает элементы первой строки и последней строки

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

void ChangeFirstLastRow(int[,] arr)
{
    int temporary = 0;
    for (int i = 0; i < 1; i++)
    {
        for (int j = 0; j < arr.GetLength(0); j++)
        {
            temporary = arr[i, j];
            arr[i, j] = arr[arr.GetLength(0) - 1, j];
            arr[arr.GetLength(0) - 1, j] = temporary;
        }
    }
}

int[,] numbers = CreateArray(5, 5);
PrintArray(numbers);
ChangeFirstLastRow(numbers);
System.Console.WriteLine();
PrintArray(numbers);