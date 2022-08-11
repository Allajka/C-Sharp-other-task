//  0. Вывести квадрат числа

System.Console.Write("Введите число для возведение его в квадрат: ");
int userNumber = Convert.ToInt32(Console.ReadLine());
int square = userNumber * userNumber;
System.Console.WriteLine($"Квадрат числа {userNumber} = {square}");