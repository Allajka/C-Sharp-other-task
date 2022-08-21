/*Составить частотный словарь элементов двумерного массива. Частотный словарь содержит информацию о том, сколько раз встречается элемент входных данных.
Пример: 
Есть набор данных { 1, 9, 9, 0, 2, 8, 0, 9 }

частотный массив может быть представлен так:
0 встречается 2 раза
1 встречается 1 раз
2 встречается 1 раз
8 встречается 1 раз
9 встречается 3 раза */

bool meetNumbers (int [] numbers, int searchNumber, int currentIndex)
{
    for (int i = 0; i < currentIndex; i++)
    {
        if(numbers[i] == searchNumber) return true;
    }
    return false;
}
int[] sortArray(int[] array)
{
    int[] newNumbers = array;
    for (int i = 0; i < newNumbers.Length - 1; i++)
    {
        int minPos = i;
        for (int j = i + 1; j < newNumbers.Length; j++)
        {
            if (newNumbers[j] < newNumbers[minPos]) minPos = j;
        }
        int temporary = newNumbers[i];
        newNumbers[i] = newNumbers[minPos];
        newNumbers[minPos] = temporary;
    }
    return newNumbers;
}

int [] numbers = { 1, 9, 9, 0, 2, 8, 0, 9, 3, 7, 5 , 5 , 5};
sortArray(numbers);

for (int i = 0; i < numbers.Length; i++)
{
    int count = 0;
    int current = numbers[i];
    for (int j = i; j < numbers.Length; j++)
    {
        if(meetNumbers(numbers,current, i ))
        {
            break;
        }
        if (numbers[j] == current)
        {
            count++;
        }
    }
    double frequency = count*100/numbers.Length;
    if (count != 0) System.Console.WriteLine ($"Число {current} встречается {count} раз. Частотность {frequency}%.");
}
