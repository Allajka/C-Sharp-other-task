//  3. По заданному номеру дня недели вывести его название

string[] weekDays = new string[] { "monday", "tuesday", "wednesday", "thursday", "friday", "saturday", "sunday" };
Console.Write("Введите порядковый номер дня недели: ");
int userDay = Convert.ToInt32(Console.ReadLine());


while (userDay <= 0 || userDay > 7)
{
    Console.Write("Не верный ввод. Введите порядковый номер дня недели от 1 до 7: ");
    userDay = Convert.ToInt32(Console.ReadLine());
}

Console.WriteLine(weekDays[userDay-1]);