// 11. Дано число из отрезка [10, 99]. Показать наибольшую цифру числа

int number = new Random().Next(10, 100);
int firstNumber = number / 10;
int lastNumber = number % 10;
int maxNumber = firstNumber;

if (lastNumber>maxNumber) maxNumber = lastNumber;

Console.Write($"Максимальная цифра {maxNumber} из числа {number}");