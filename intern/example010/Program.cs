// 10. Показать вторую цифру трёхзначного числа

int number = new Random().Next(100, 1000);
int result = (number / 10) % 10;

Console.WriteLine($"Вторая цифра {result} трехзначного числа {number}");
