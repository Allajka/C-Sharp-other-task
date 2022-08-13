// 28. Подсчитать сумму цифр в числе

Console.Write("Введите число: ");
string? number = Console.ReadLine();
char[] arr = number.ToCharArray();

int a = Convert.ToInt32(arr[0]);
int b = Convert.ToInt32(arr[1]);

Console.WriteLine(a+b);

// int result = Convert.ToInt32(arr[0]);
// Console.WriteLine(result);

// for (int i = 0; i<arr.Length; i++)
// {
//     result += Convert.ToInt32(arr[i]);
// }

// Console.WriteLine(result);