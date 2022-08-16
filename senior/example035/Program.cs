// 35. Определить, присутствует ли в заданном массиве, некоторое число 

int controlSymbol (int [] numbers, int C)
{
    int counter = 0;
    int control = C;
    for (int j = 0; j <= numbers.Length-1; j++)
    {
        if (control == numbers[j]) counter += 1;
    }
    return counter;
}

int [] numbers = { 1, 9, 9, 0, 2, 8, 0, 9 };
Console.Write("Введите целое число для поиска: ");
int userSymbol = Convert.ToInt32(Console.ReadLine());

int meets = controlSymbol(numbers, userSymbol);
System.Console.WriteLine($"Число {userSymbol} встречается {meets} раз");
