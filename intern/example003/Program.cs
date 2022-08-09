//  2. Даны два числа. Показать большее и меньшее число

int first = new Random().Next(0, 10);
int second = new Random().Next(0, 10);

if (first > second)
{
    Console.WriteLine($"{first} большее число");
    Console.WriteLine($"{second} меньшее число");
}
else
{
    Console.WriteLine($"{second} большее число");
    Console.WriteLine($"{first} меньшее число");
}