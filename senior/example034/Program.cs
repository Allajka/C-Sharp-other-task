// 34. Написать программу замену элементов массива на противоположные
void Reversal<T>(T[] arr)
{
    T box;
    for (int i = 0; i < arr.Length / 2; i++)
    {
        box = arr[i];
        arr[i] = arr[arr.Length - 1 - i];
        arr[arr.Length - 1 - i] = box;
    }
}

int[] numbers = { 2, 6, 8, 5, 7, 5, 3, 5 };
string[] letters = { "в", "а", "п", "ц", "с", "у" };

Console.WriteLine("[{0}]", string.Join(", ", numbers));
Reversal(numbers);
Console.WriteLine("[{0}]", string.Join(", ", numbers));
Console.WriteLine("[{0}]", string.Join(", ", letters));
Reversal(letters);
Console.WriteLine("[{0}]", string.Join(", ", letters));