// 6. Выяснить является ли число чётным

int number = new Random().Next(1, 10);

if (number % 2 == 0) Console.WriteLine($"Число {number} четное");
else Console.WriteLine($"Число {number} не четное");