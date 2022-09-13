// 35. Определить, присутствует ли в заданном массиве, некоторое число 
int[] CreateArray(int length)
{
    int[] arr = new int[length];
    for (int i = 0; i < length; i++)
    {
        arr[i] = new Random().Next(0, 100);
    }
    return arr;
}

int controlNumber(int[] numbers, int C)
{
    int counter = 0;
    int control = C;
    for (int j = 0; j <= numbers.Length - 1; j++)
    {
        if (control == numbers[j]) counter += 1;
    }
    return counter;
}

int[] numbers = CreateArray(length: 10);

Console.Write("Введите целое число для поиска: ");
int userSymbol = Convert.ToInt32(Console.ReadLine());

int meets = controlNumber(numbers, userSymbol);
System.Console.WriteLine($"Число {userSymbol} встречается {meets} раз");
Console.WriteLine("Массив " + "[{0}]", string.Join(", ", numbers));
