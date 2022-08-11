// 12. Удалить вторую цифру трёхзначного числа

int number = new Random().Next(100, 1000);
int firstNumber = number / 100;
int secondNumber = (number / 10) % 10;
int thirdNumber = number % 10;
int result = firstNumber * 10 + thirdNumber;
Console.Write($"Удаление второго числа {number} -> {result}"); 