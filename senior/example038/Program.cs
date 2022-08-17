// 38. Найти сумму чисел одномерного массива стоящих на нечетной позиции

int[] createArray(int lengthArray, int minNumber, int maxNumber)
{
    int[] arr = new int[lengthArray];
    for (int i = 0; i < arr.Length; i++)
    {
        arr[i] = new Random().Next(minNumber, maxNumber);
    }
    return arr;
}

void printArray(int[] arr)
{
    Console.Write("[");
    for (int i = 0; i < arr.Length; i++)
    {
        if (i < arr.Length - 1) Console.Write($"{arr[i]}, ");
        else Console.Write($"{arr[i]}");
    }
    Console.Write("]");
    System.Console.WriteLine();
}

int[] numbers = createArray(10, 0, 10);
printArray(numbers);
int sum = 0;
for (int i = 0; i < numbers.Length; i++)
{
    if (i == 0) sum += numbers[i];
    else
    {
        if(i % 2 == 0) sum += numbers[i];
    } 

}
Console.WriteLine($"Сумма чисел массива стоящих на нечетной позиции равна: {sum}");


