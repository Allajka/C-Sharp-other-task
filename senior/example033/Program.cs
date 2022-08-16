// 33. Задать массив из 12 элементов, заполненных числами из [0,9]. Найти сумму положительных/отрицательных элементов массива

int [] createArray (int N)
{
    int [] newArray = new int [N];
    for (int i = 0; i < newArray.Length; i++)
    {
        newArray[i] = new Random().Next(0, 10);
    }
    return newArray;
}
void printArray (int [] arr)
{
    Console.Write("Массив: ");
    for (int i = 0; i < arr.Length; i++)
    {
        Console.Write(arr [i] + " ");
    }
}

int positiveSumNumbers (int [] arr)
{
    int result = 0;
    for (int i = 0; i < arr.Length; i++)
    {
        if (arr[i] > 0) result+= arr[i];
    }
    return result;
}

int negativeSumNumbers (int [] arr)
{
    int result = 0;
    for (int i = 0; i < arr.Length; i++)
    {
        if (arr[i] < 0) result+= arr[i];
    }
    return result;
}

int element = 12;
int [] numbers = createArray(element);
printArray(numbers);
Console.WriteLine($"\nСумма положительных цифр равна {positiveSumNumbers(numbers)}");
Console.WriteLine($"Сумма отрицательных цифр равна {negativeSumNumbers(numbers)}");