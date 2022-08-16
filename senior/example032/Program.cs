// 32. Задать массив из 8 элементов, заполненных нулями и единицами вывести их на экран 

int[] createArray(int N) 
{
    int[] Array = new int [N];
    for (int i = 0; i <= N - 1; i++)
    {
        Array[i] = new Random().Next(0,2);
    }
    return Array;
}

void printArray (int[] array)
{
    for (int i = 0; i < array.Length; i++)
    {
        Console.Write(array[i] + " ");
    }
}

int N = 8;
int[] numbers = createArray(N);
Console.Write("Массив: ");
printArray(numbers);
