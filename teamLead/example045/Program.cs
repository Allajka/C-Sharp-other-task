/* 45. Показать числа Фибоначчи
в которой первые два числа равны 0 и 1, а каждое последующее число равно сумме двух предыдущих чисел*/
Console.Write($"Введите окончание последовательности чисел Фибоначчи от 1 до :");
int end = Convert.ToInt32(Console.ReadLine());

int first = 0;
int second = 1;
int result = 0;

Console.Write(first + ", " + second + ", " ); 
while (result <= end)
{
      result = first + second;
      first = second;
      second = result;
      Console.Write($"{result}, "); 
}

// Console.Write("0 ");
// int j = 1;
// for (int i = 1; i < end; i += j)
// {
//     Console.Write("{0} ", i);
//     j = i - j;
// }


