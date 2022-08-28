/* Составить частотный словарь элементов двумерного массива 
Частотный словарь содержит информацию о том, сколько раз встречается элемент входных данных.
Пример: 
Есть набор данных 
```
{ 1, 9, 9, 0, 2, 8, 0, 9 }
```
частотный массив может быть представлен так:
```
0 встречается 2 раза
1 встречается 1 раз
2 встречается 1 раз
8 встречается 1 раз
9 встречается 3 раза 

0 2
1 1
2 1
8 1
9 3  */
int UniqueNumber(int[] arr, int number)
{
    int count = 0;
    for (int i = 0; i < arr.Length; i++)
    {
        if (arr[i] == number) count++;
    }
    return count;
}
void PrintArray(int[,] arr, int lenght)
{
    for (int i = 0; i < lenght; i++)
    {
        for (int j = 0; j < 1; j++)
        {
            Console.Write($"{arr[i, j]} встречается {arr[i, j+1]}");
        }
        Console.WriteLine();
    }
}

int[] numbers = { 1, 9, 9, 0, 2, 8, 0, 9 };
int[,] dictionary = new int[10, 2];


int[] unicNumber = new int [numbers.Length];

for (int i = 0; i < unicNumber.Length; i++)
{
    unicNumber[i] = -1;
}

int count = 0;
for (int i = 0; i < numbers.Length; i++)
{
    bool flag = true;
    for (int j = 0; j < count; j++)
    {
        if (numbers[i] == unicNumber[j])
        {
            flag = false;
            break;
        }   
    }
    if(flag)
    {
        unicNumber[count] = numbers[i];
        count ++;
    }
}

// Console.WriteLine(string.Join(" " , unicNumber));

Array.Resize(ref unicNumber, count);

// Console.WriteLine(string.Join(" " , unicNumber));

Array.Sort(unicNumber);
// Console.WriteLine(string.Join(" " , unicNumber));

for (int i = 0; i < unicNumber.Length; i++)
{
    int r = UniqueNumber(numbers, unicNumber[i]);
    dictionary[i, 0] = unicNumber[i];
    dictionary[i, 1] = r;
}
PrintArray(dictionary, count);