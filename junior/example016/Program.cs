// 16. Дано число обозначающее день недели. Выяснить является номер дня недели выходным 

Console.Write("Введите порядковый номер дня недели:  ");
string Day = Console.ReadLine()!;

int userDay = 20;
while(true)
{
    Console.Write("Введите порядковый номер дня недели числом:  ");
    Day = Console.ReadLine()!;
    bool flag = int.TryParse(Day, out userDay); /*принимает на вход 
какую-то строку и пытается превратить эту сроку в тот тип, что ему 
указали. и передает true false*/
    if (flag && userDay >= 1 && userDay <= 7) break; 
}

string[] weekDays = new string[] { "Monday", "Tuesday", "Wednesday ", "Thursday", "Friday ", "Saturday", "Sunday" };

while (userDay > 7 || userDay <= 0) 
{
    Console.Write("Введите порядковый номер дня недели от 1 до 7:  ");
    userDay = Convert.ToInt32(Console.ReadLine());
}

if (userDay == 6 || userDay == 7) Console.WriteLine($"{weekDays[userDay-1]} выходной"); 
else Console.WriteLine($"{weekDays[userDay-1]} будний день");


// if (int.TryParse(userDay, out int number))
// {
//     while (userDay > 7 || userDay <= 0) 
//         {
//             Console.Write("Введите порядковый номер дня недели от 1 до 7:  ");
//             userDay = Convert.ToInt32(Console.ReadLine());
//         }

//     if (userDay == 6 || userDay == 7) Console.WriteLine($"{weekDays[userDay-1]} выходной"); 
//     else Console.WriteLine($"{weekDays[userDay-1]} будний день");
// }
// else
// {
//     Console.WriteLine("Некорректный ввод числа");
// }
  


