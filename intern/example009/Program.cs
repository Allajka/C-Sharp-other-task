// 9. Показать последнюю цифру трёхзначного числа

int number = new Random().Next(100, 1000);
int mod  = number % 10;

Console.WriteLine($"Последнее число {mod} числа {number}");