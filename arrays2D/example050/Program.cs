// 50. В двумерном массиве n×k заменить четные элементы на противоположные

int[,] array = new int[3, 3];
void FillArray(int[,] array)
{
    int rows = array.GetLength(0), cols = array.GetLength(1);
    for (int row = 0; row < rows; row++)
    {
        for (int col = 0; col < cols; col++)
        {
            array[row, col] = new Random().Next(-10, 10);
        }
    }
}

void change (int[,] array)
{
    int rows = array.GetLength(0), cols = array.GetLength(1);
    for (int row = 0; row < rows; row++)
    {
        for (int col = 0; col < cols; col++)
        {
            if (array[row, col] % 2 == 0)
            {
                array[row, col] = array[row, col];
                if (array[row, col] > 0)
                {
                    array[row, col] = -array[row, col];
                }
                if (array[row, col] < 0)
                {
                    array[row, col] = array[row, col];
                }
            }
        }
    }
}

void PrintArray(int[,] array)
{
    int rows = array.GetLength(0), cols = array.GetLength(1);
    for (int row = 0; row < rows; row++)
    {
        for (int col = 0; col < cols; col++)
        {
            Console.Write($"{array[row, col],3}");
        }
        Console.WriteLine();
    }
}
FillArray(array);
PrintArray(array);
change(array);
Console.WriteLine();

PrintArray(array);
