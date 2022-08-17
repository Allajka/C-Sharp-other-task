﻿// 36. Задать массив, заполнить случайными положительными трёхзначными числами. Показать количество нечетных\четных чисел

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
    Console.Write("Массив: ");
    for (int i = 0; i < arr.Length; i++)
    {
        Console.Write(arr[i] + " ");
    }
    System.Console.WriteLine();
}

int[] numbers = createArray(10, 100, 1000);
printArray(numbers);

Console.Write($"Четные цифры: ");
for (int i = 0; i < numbers.Length; i++)
{
    if (numbers[i] % 2 == 0) Console.Write(numbers[i] + " ");
}
System.Console.WriteLine();
Console.Write($"Нечетные цифры: ");
for (int i = 0; i < numbers.Length; i++)
{
    if (numbers[i] % 2 != 0) Console.Write(numbers[i] + " ");
}