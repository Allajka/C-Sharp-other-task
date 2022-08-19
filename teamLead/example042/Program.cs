// 42. Определить сколько чисел больше 0 введено с клавиатуры

int count = 0;
Console.WriteLine("Подсчет чисел больше 0. Для прекращения введите q/");
while (true)
{
    Console.Write("Введите число: ");
    string number = Console.ReadLine()!;
    if (number == "q") break;
    if (Convert.ToInt32(number) > 0) count++;
}
System.Console.WriteLine($"Введено {count} чисел больше 0.");