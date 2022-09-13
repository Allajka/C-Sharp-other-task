/* 45. Показать числа Фибоначчи
в которой первые два числа равны 0 и 1, а каждое последующее число равно сумме двух предыдущих чисел*/

void PrintFibonacci(int end, int first = 0, int second = 1, int result = 0)
{
    Console.Write($"{first, 10} {second, 10}");
    int index = 2;
    while (result <= end)
    {
        result = first + second;
        first = second;
        second = result;
        Console.Write($"{result, 10} ");
        index++;
        if (index == 10)
        {
            Console.WriteLine();
            index = 0;
        }
    }
}

Console.Write($"Введите до какого числа выводить последовательность чисел Фибоначчи от 1 до : ");
int end = Convert.ToInt32(Console.ReadLine());
PrintFibonacci(end);


// double Fibonacci(int n)
// {
//     if (n == 1 || n == 2) return 1;
//     else return Fibonacci(n - 1) + Fibonacci(n - 2);
// }
// for (int i = 1; i < 50; i++)
// {
//    Console.Write($"F{i} = {Fibonacci(i)}, ");    
// }

// Console.Write("0 ");
// int j = 1;
// for (int i = 1; i < end; i += j)
// {
//     Console.Write("{0} ", i);
//     j = i - j;
// }


