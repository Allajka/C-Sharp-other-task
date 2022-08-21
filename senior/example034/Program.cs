// 34. Написать программу замену элементов массива на противоположные
void printArrayNumber(int[] arr)
{
    Console.Write("Массив: ");
    for (int i = 0; i < arr.Length; i++)
    {
        Console.Write(arr[i] + " ");
    }
}

void printArrayletters(string[] arr)
{
    Console.Write("Массив: ");
    for (int i = 0; i < arr.Length; i++)
    {
        Console.Write(arr[i] + " ");
    }
}

int[] numbers = { 2, 6, 8, 5, 7, 5, 3 };
string[] letters = { "в", "а", "п", "ц", "с", "у" };

int box = 0;

for (int i = 0; i < numbers.Length / 2; i++)
{
    box = numbers[i];
    numbers[i] = numbers[numbers.Length - 1 - i];
    numbers[numbers.Length - 1 - i] = box;
}

string temporary = string.Empty;;
for (int i = 0; i < letters.Length / 2; i++)
{
    temporary = letters[i];
    letters[i] = letters[letters.Length - 1 - i];
    letters[letters.Length - 1 - i] = temporary;
}

printArrayNumber(numbers);
printArrayletters(letters);
