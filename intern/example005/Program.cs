//  4. Найти максимальное из трех чисел

int firstNumber = new Random().Next(0, 100);
int secondNumber = new Random().Next(0, 100);;
int thirdNumber = new Random().Next(0, 100);;
int maxNumber = firstNumber;

if (secondNumber>maxNumber) maxNumber=secondNumber;
if (thirdNumber>maxNumber) maxNumber=thirdNumber;

Console.WriteLine($"Max = {maxNumber} из цифр {firstNumber}, {secondNumber}, {thirdNumber}");
