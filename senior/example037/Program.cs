// 37. В одномерном массиве из 123 чисел найти количество элементов из отрезка [10,99]

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
    Console.WriteLine("Массив: ");
    for (int i = 0; i < arr.Length; i++)
    {
        Console.Write($"{arr[i], 3} ");
        if(i>0)
        {
            if (i % 20 == 0 ) System.Console.WriteLine();
        }
    }

    System.Console.WriteLine();
}

int searchNumber (int[] numbers, int segmentStart, int segmentFinish)
{
    int counter = 0;
    for (int i = 0; i <= numbers.Length - 1; i++)
    {
        if (numbers [i] >= segmentStart && numbers [i] <= segmentFinish) counter += 1;
    }
    return counter;
}

int[] arr = createArray(123, 0, 200);
printArray(arr);
int meet = searchNumber(arr, 10, 99);

Console.WriteLine($"В массиве из 123 числ, встречается {meet} раза числа из отрезка [10,99]");